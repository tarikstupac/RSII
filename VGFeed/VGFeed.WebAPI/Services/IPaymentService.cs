using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model.Requests;

namespace VGFeed.WebAPI.Services
{
    public interface IPaymentService
    {
        Model.Donacije Insert(DonacijeInsertRequest request);
        List<Model.Donacije> Get(DonacijeSearchRequest search);
    }
}
