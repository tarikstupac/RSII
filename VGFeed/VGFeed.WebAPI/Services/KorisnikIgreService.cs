using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;

namespace VGFeed.WebAPI.Services
{
    public class KorisnikIgreService : BaseCRUDService<Model.KorisnikIgre, KorisnikIgreSearchRequest, Database.KorisnikIgre, KorisnikIgreInsertRequest, KorisnikIgreInsertRequest>
    {
        public KorisnikIgreService(_3123Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.KorisnikIgre> Get(KorisnikIgreSearchRequest search)
        {
            var query = _context.Set<Database.KorisnikIgre>().Include(x=>x.Korisnik).Include(x=>x.Igra).ThenInclude(x=> x.Platform).AsQueryable();

            if (search?.IgraId.HasValue == true && search.IgraId != 0)
            {
                query = query.Where(x => x.IgraId == search.IgraId);

            }

            if (search?.KorisnikId.HasValue == true && search.KorisnikId != 0)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if (search.Zainteresiran != null)
            {
                query = query.Where(x => x.Zainteresiran == search.Zainteresiran);
            }
            if (search.Igrao != null)
            {
                query = query.Where(x => x.Igrao == search.Igrao);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.KorisnikIgre>>(list);
        }
    }
}
