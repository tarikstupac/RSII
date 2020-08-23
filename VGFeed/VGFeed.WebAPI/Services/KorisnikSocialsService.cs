using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;

namespace VGFeed.WebAPI.Services
{
    public class KorisnikSocialsService : BaseCRUDService<Model.KorisnikSocials, KorisnikSocialsSearchRequest, Database.KorisnikSocials, KorisnikSocialsInsertRequest, KorisnikSocialsInsertRequest>
    {
        public KorisnikSocialsService(_3123Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.KorisnikSocials> Get(KorisnikSocialsSearchRequest search)
        {
            var query = _context.Set<Database.KorisnikSocials>().AsQueryable();
            if (search?.KorisnikId.HasValue == true && search.KorisnikId != 0)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.KorisnikSocials>>(list);
        }
    }
}
