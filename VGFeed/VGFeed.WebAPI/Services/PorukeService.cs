using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;

namespace VGFeed.WebAPI.Services
{
    public class PorukeService : IPorukeService
    {
        protected readonly _3123Context _context;
        protected readonly IMapper _mapper;

        public PorukeService(_3123Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Poruke> Get(PorukeSearchRequest search)
        {
            var query = _context.Set<Database.Poruke>().AsQueryable();
            if (search.Kontakt != 0 && search.TrenutniKorisnik != 0)
            {
                query = query.Where(x => (x.Primalac == search.TrenutniKorisnik && x.Posiljalac == search.Kontakt)
                || (x.Posiljalac == search.TrenutniKorisnik && x.Primalac == search.Kontakt)).OrderBy(x=>x.DatumKreiranja);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Poruke>>(list);
        }

        public Model.Poruke Insert(PorukeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Poruke>(request);

            _context.Set<Database.Poruke>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Poruke>(entity);
        }

        public Model.Poruke Update(int id, PorukeInsertRequest request)
        {
            var entity = _context.Set<Database.Poruke>().Find(id);
            _context.Set<Database.Poruke>().Attach(entity);
            _context.Set<Database.Poruke>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Poruke>(entity);
        }
    }
}
