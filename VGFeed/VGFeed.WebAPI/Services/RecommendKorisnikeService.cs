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
    public class RecommendKorisnikeService : IRecommendService<Model.Korisnici>
    {
        protected readonly _3123Context _context;
        protected readonly IMapper _mapper;
        Dictionary<int, List<Model.KorisnikIgre>> korisnici = new Dictionary<int, List<Model.KorisnikIgre>>();
        public RecommendKorisnikeService(_3123Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> GetSlicni(int id)
        {
            UcitajKorisnike(id);

            List<Model.KorisnikIgre> ocjenePosmatranogKorisnika = new List<Model.KorisnikIgre>();
            List<Database.KorisnikIgre> ocjeneizbaze = _context.KorisnikIgre.Where(x => x.KorisnikId == id).OrderBy(y => y.IgraId).ToList();
            _mapper.Map(ocjeneizbaze, ocjenePosmatranogKorisnika);

            List<Model.KorisnikIgre> zajednickeOcjene1 = new List<Model.KorisnikIgre>();
            List<Model.KorisnikIgre> zajednickeOcjene2 = new List<Model.KorisnikIgre>();
            List<Model.Korisnici> preporuceniKorisnici = new List<Model.Korisnici>();

            foreach (var item in korisnici)
            {
                foreach (Model.KorisnikIgre o in ocjenePosmatranogKorisnika)
                {
                    if (item.Value.Where(x => x.IgraId == o.IgraId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.IgraId == o.IgraId).First());
                    }
                }

                double slicnosti = 0;
                slicnosti = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);


                if (slicnosti > 0.99)
                {
                    Database.Korisnici element1 = _context.Korisnici.Where(x => x.KorisnikId == item.Key).FirstOrDefault();
                    Model.Korisnici element2 = new Model.Korisnici();
                    _mapper.Map(element1, element2);

                    preporuceniKorisnici.Add(element2);

                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniKorisnici;

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
        private void UcitajKorisnike(int korisnikid)
        {
            List<Database.Korisnici> aktivniKorisnici = _context.Korisnici.Where(x => x.KorisnikId != korisnikid).ToList();

            Database.Korisnici posmatranikorisnik = _context.Korisnici.Where(x => x.KorisnikId == korisnikid).SingleOrDefault();

            List<Model.Korisnici> novalista = new List<Model.Korisnici>();
            _mapper.Map(aktivniKorisnici, novalista);

            List<Model.Korisnici> listakonacna = new List<Model.Korisnici>();
            foreach (var item in novalista)
            {
                    listakonacna.Add(item);
            }

            foreach (Model.Korisnici a in listakonacna)
            {
                List<Database.KorisnikIgre> novalistaocjena = _context.KorisnikIgre.Where(x => x.KorisnikId == a.KorisnikId).ToList();
                List<Model.KorisnikIgre> ocjene = new List<Model.KorisnikIgre>();
                foreach (var item2 in novalistaocjena)
                {

                    Model.KorisnikIgre novaocjena = new Model.KorisnikIgre();
                    _mapper.Map(item2, novaocjena);
                    ocjene.Add(novaocjena);
                }

                if (ocjene.Count > 0)
                    korisnici.Add(a.KorisnikId, ocjene);
            }
        }
    }
}
