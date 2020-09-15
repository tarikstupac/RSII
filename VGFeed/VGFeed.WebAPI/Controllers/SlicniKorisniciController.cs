using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SlicniKorisniciController : ControllerBase
    {
        private readonly IRecommendService<Model.Korisnici> _service;
        public SlicniKorisniciController(IRecommendService<Model.Korisnici> service)
        {
            _service = service;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("GetSlicni/{korisnikID}")]
        public List<Model.Korisnici> GetSlicni(int korisnikID)
        {
            return _service.GetSlicni(korisnikID);
        }
    }
}
