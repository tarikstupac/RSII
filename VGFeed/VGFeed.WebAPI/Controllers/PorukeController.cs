using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PorukeController : ControllerBase
    {
        private readonly IPorukeService _service;

        public PorukeController(IPorukeService service)
        {
            _service = service;
        }
        [HttpPost]
        public Model.Poruke Insert(PorukeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Poruke Update(int id,[FromBody] PorukeInsertRequest request)
        {
            return _service.Update(id, request);
        }
        [HttpGet]
        public List<Model.Poruke> Get([FromQuery]PorukeSearchRequest search)
        {
            return _service.Get(search);
        }
    }
}