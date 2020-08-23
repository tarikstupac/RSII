using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model.Requests;

namespace VGFeed.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();

            CreateMap<Database.Igre, Model.Igre>();
            CreateMap<IgreInsertRequest, Database.Igre>();

            CreateMap<Database.Drzave, Model.Drzave>();

            CreateMap<Database.Zanrovi, Model.Zanrovi>();
            CreateMap<ZanroviInsertRequest, Database.Zanrovi>();

            CreateMap<Database.Platforme, Model.Platforme>();
            CreateMap<PlatformeInsertRequest, Database.Platforme>();

            CreateMap<Database.Uloge, Model.Uloge>();

            CreateMap<Database.Store, Model.Store>();
            CreateMap<StoreInsertRequest, Database.Store>();

            CreateMap<Database.Sale, Model.Sale>();
            CreateMap<SaleInsertRequest, Model.Sale>();

            CreateMap<Database.SaleDetalji, Model.SaleDetalji>();
            CreateMap<SaleDetaljiStavka, Model.SaleDetalji>();

            CreateMap<Database.KorisnikIgre, Model.KorisnikIgre>();
            CreateMap<KorisnikIgreInsertRequest, Database.KorisnikIgre>();

            CreateMap<Database.KorisnikSocials, Model.KorisnikSocials>();
            CreateMap<KorisnikSocialsInsertRequest, Database.KorisnikSocials>();

            CreateMap<Database.Donacije, Model.Donacije>();
            CreateMap<DonacijeInsertRequest, Database.Donacije>();

            CreateMap<Database.Poruke, Model.Poruke>();
            CreateMap<PorukeInsertRequest, Database.Poruke>();
        }
    }
}
