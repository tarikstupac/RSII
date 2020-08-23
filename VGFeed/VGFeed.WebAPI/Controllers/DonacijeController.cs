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
    public class DonacijeController : ControllerBase
    {
        private readonly IPaymentService _service;

        public DonacijeController(IPaymentService service)
        {
            _service = service;
        }
        [HttpPost]
        public Model.Donacije Insert(DonacijeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}