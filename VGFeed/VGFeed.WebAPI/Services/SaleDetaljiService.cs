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
    public class SaleDetaljiService : BaseService<Model.SaleDetalji, SaleDetaljiSearchRequest, Database.SaleDetalji>
    {
        public SaleDetaljiService(_3123Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.SaleDetalji> Get(SaleDetaljiSearchRequest search)
        {
            var list = _context.SaleDetalji
                .Include(x => x.Igra)
                .ThenInclude(x => x.Platform)
                .Where(x => x.SaleId == search.SaleId)
                .ToList();

            return _mapper.Map<List<Model.SaleDetalji>>(list);
        }
    }
}
