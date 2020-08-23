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
    public class SaleService : BaseCRUDService<Model.Sale, SaleSearchRequest, Database.Sale, SaleInsertRequest, SaleInsertRequest>
    {
        public SaleService(_3123Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Sale> Get(SaleSearchRequest search)
        {
            var date = new DateTime(1900, 1, 1);
            var query = _context.Set<Database.Sale>().Include(x=>x.Store)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if (search.DatumStart != null && search.DatumEnd != null && search.DatumEnd>date)
            {
                var datumend = search.DatumEnd.AddDays(1);
                query = query.Where(x => x.DatumStart>=search.DatumStart && x.DatumEnd<datumend);

            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Sale>>(list);
        }

        public override Model.Sale Insert(SaleInsertRequest request)
        {

            var entity = new Database.Sale()
            {
                DatumEnd = request.DatumEnd,
                DatumStart = request.DatumStart,
                Naziv = request.Naziv,
                SaleLink = request.SaleLink,
                StoreId = request.StoreId
            };
            _context.Sale.Add(entity);
            _context.SaveChanges();

            foreach (var item in request.SaleDetaljiStavke)
            {
                Database.SaleDetalji saleDetalji = new Database.SaleDetalji();
                saleDetalji.SaleId = entity.SaleId;
                saleDetalji.IgraId = item.IgraId;
                saleDetalji.Popust = item.Popust;
                saleDetalji.Cijena = item.Cijena;
                saleDetalji.FizickaKopija = item.FizickaKopija;
                saleDetalji.StoreLink = item.StoreLink;
                _context.Add(saleDetalji);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Sale>(entity);
        }
        public override Model.Sale Update(int id, SaleInsertRequest request)
        {

            var entity = _context.Sale.Find(id);
            _context.Attach(entity);
            _context.Update(entity);
            entity.DatumEnd = request.DatumEnd;
            entity.DatumStart = request.DatumStart;
            entity.Naziv = request.Naziv;
            entity.SaleLink = request.SaleLink;
            entity.StoreId = request.StoreId;
            _context.SaveChanges();
            foreach (var item in request.SaleDetaljiStavke)
            {
                var saleDetalji = _context.SaleDetalji.Find(item.SaleDetaljiId);
                _context.Attach(saleDetalji);
                _context.Update(saleDetalji);
                saleDetalji.SaleId = id;
                saleDetalji.IgraId = item.IgraId;
                saleDetalji.Popust = item.Popust;
                saleDetalji.Cijena = item.Cijena;
                saleDetalji.FizickaKopija = item.FizickaKopija;
                saleDetalji.StoreLink = item.StoreLink;
                _context.SaveChanges();
            }

            return _mapper.Map<Model.Sale>(entity);
        }

    }
}
