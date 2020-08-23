using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Controllers
{
    public class KorisnikIgreController : BaseCRUDController<Model.KorisnikIgre, KorisnikIgreSearchRequest, KorisnikIgreInsertRequest, KorisnikIgreInsertRequest>
    {
        public KorisnikIgreController(ICRUDService<KorisnikIgre, KorisnikIgreSearchRequest, KorisnikIgreInsertRequest, KorisnikIgreInsertRequest> service) : base(service)
        {
        }
    }
}