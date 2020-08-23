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
    public class IgreController : BaseCRUDController<Model.Igre, IgreSearchRequest, IgreInsertRequest, IgreInsertRequest>
    {
        public IgreController(ICRUDService<Igre, IgreSearchRequest, IgreInsertRequest, IgreInsertRequest> service) : base(service)
        {
        }
    }

}