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
    public class StoreController : BaseCRUDController<Model.Store, object, StoreInsertRequest, StoreInsertRequest>
    {
        public StoreController(ICRUDService<Store, object, StoreInsertRequest, StoreInsertRequest> service) : base(service)
        {
        }
    }
}