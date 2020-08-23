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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendController : ControllerBase
    {
        private readonly IRecommendService<Model.Igre> _service;
        public RecommendController(IRecommendService<Model.Igre> service)
        {
            _service = service;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("GetSlicni/{igraID}")]
        public List<Model.Igre> GetSlicni(int igraID)
        {
            return _service.GetSlicni(igraID);
        }
    }
}