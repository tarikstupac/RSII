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
    public class IgreService : BaseCRUDService<Model.Igre, IgreSearchRequest, Database.Igre, IgreInsertRequest,IgreInsertRequest>
    {
        public IgreService(_3123Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Igre> Get(IgreSearchRequest search)
        {
            var query = _context.Set<Database.Igre>().Include(x=>x.Platform).Include(x=>x.Zanr).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if (search?.PlatformaId.HasValue == true && search.PlatformaId!=0)
            {
                query = query.Where(x => x.PlatformId == search.PlatformaId);
                
            }
           
            if (search?.ZanrId.HasValue == true && search.ZanrId!=0)
            {
                query = query.Where(x => x.ZanrId == search.ZanrId);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Igre>>(list);
        }
    }
}
