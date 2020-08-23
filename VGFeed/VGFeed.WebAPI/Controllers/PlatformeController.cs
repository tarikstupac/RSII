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
    public class PlatformeController : BaseCRUDController<Model.Platforme, object, PlatformeInsertRequest, PlatformeInsertRequest>
    {
        public PlatformeController(ICRUDService<Platforme, object, PlatformeInsertRequest, PlatformeInsertRequest> service) : base(service)
        {
        }
    }
}