using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles ="Administrator")]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, [FromBody]KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
        [AllowAnonymous]
        [HttpPost("{username}:{password}")]
        public Model.Korisnici Authenticate(string username,string password)
        {
           return _service.Authenticiraj(username, password);          
        }
    }
}
