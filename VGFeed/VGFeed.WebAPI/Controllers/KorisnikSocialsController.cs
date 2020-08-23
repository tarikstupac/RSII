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
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikSocialsController : BaseCRUDController<Model.KorisnikSocials, KorisnikSocialsSearchRequest, KorisnikSocialsInsertRequest, KorisnikSocialsInsertRequest>
    {
        public KorisnikSocialsController(ICRUDService<KorisnikSocials, KorisnikSocialsSearchRequest, KorisnikSocialsInsertRequest, KorisnikSocialsInsertRequest> service) : base(service)
        {
        }
    }
}