using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model;
using VGFeed.WebAPI.Database;

namespace VGFeed.WebAPI.Services
{
    public class RecommendIgreService : IRecommendService<Model.Igre>
    {
        protected readonly _3123Context _context;
        protected readonly IMapper _mapper;
        Dictionary<int, List<Model.KorisnikIgre>> igre = new Dictionary<int, List<Model.KorisnikIgre>>();
        public RecommendIgreService(_3123Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Igre> GetSlicni(int id)
        {
            UcitajIgre(id);

            List<Model.KorisnikIgre> ocjenePosmatraneIgre = new List<Model.KorisnikIgre>();
            List<Database.KorisnikIgre> ocjeneizbaze = _context.KorisnikIgre.Where(x => x.IgraId == id).OrderBy(y => y.KorisnikId).ToList();
            _mapper.Map(ocjeneizbaze, ocjenePosmatraneIgre);

            List<Model.KorisnikIgre> zajednickeOcjene1 = new List<Model.KorisnikIgre>();
            List<Model.KorisnikIgre> zajednickeOcjene2 = new List<Model.KorisnikIgre>();
            List<Model.Igre> preporuceneIgre = new List<Model.Igre>();

            foreach (var item in igre)
            {
                foreach (Model.KorisnikIgre o in ocjenePosmatraneIgre)
                {
                    if (item.Value.Where(x => x.KorisnikId == o.KorisnikId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KorisnikId == o.KorisnikId).First());
                    }
                }

                double slicnosti = 0;
                slicnosti = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);


                if (slicnosti > 0.99)
                {
                    Database.Igre element1 = _context.Igre.Include(y => y.Zanr).Include(z => z.Platform).Where(x => x.IgraId == item.Key).FirstOrDefault();
                    Model.Igre element2 = new Model.Igre();
                    _mapper.Map(element1, element2);
                    
                    preporuceneIgre.Add(element2);

                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceneIgre;

        }
        private double GetSlicnost(List<Model.KorisnikIgre> zajednickeOcjene1, List<Model.KorisnikIgre> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                if (zajednickeOcjene1[i].Ocjena.HasValue && zajednickeOcjene2[i].Ocjena.HasValue)
                {
                    brojnik += zajednickeOcjene1[i].Ocjena.Value * zajednickeOcjene2[i].Ocjena.Value;
                    nazivnik1 += zajednickeOcjene1[i].Ocjena.Value * zajednickeOcjene1[i].Ocjena.Value;
                    nazivnik2 += zajednickeOcjene2[i].Ocjena.Value * zajednickeOcjene2[i].Ocjena.Value;
                }
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }
        private void UcitajIgre(int igraid)
        {
            List<Database.Igre> aktivneIgre = _context.Igre.Include(y => y.Zanr).Include(z => z.Platform).Where(x => x.IgraId != igraid).ToList();

            Database.Igre posmatranaigra = _context.Igre.Where(x => x.IgraId == igraid).SingleOrDefault();

            List<Model.Igre> novalista = new List<Model.Igre>();
            _mapper.Map(aktivneIgre, novalista);

            List<Model.Igre> listakonacna = new List<Model.Igre>();
            foreach (var item in novalista)
            {
                if (item.ZanrId == posmatranaigra.ZanrId)
                {
                    listakonacna.Add(item);
                }
            }

            foreach (Model.Igre a in listakonacna)
            {
                List<Database.KorisnikIgre> novalistaocjena = _context.KorisnikIgre.Where(x => x.IgraId == a.IgraId).ToList();
                List<Model.KorisnikIgre> ocjene = new List<Model.KorisnikIgre>();
                foreach (var item2 in novalistaocjena)
                {

                    Model.KorisnikIgre novaocjena = new Model.KorisnikIgre();
                    _mapper.Map(item2, novaocjena);
                    ocjene.Add(novaocjena);
                }

                if (ocjene.Count > 0)
                    igre.Add(a.IgraId, ocjene);

            }
        }
    }
}
