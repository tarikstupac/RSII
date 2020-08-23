using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VGFeed.Model;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Controllers
{
 
    public class DrzaveController : BaseController<Model.Drzave, object>
    {
        public DrzaveController(IService<Drzave, object> service) : base(service)
        {
        }
    }
}