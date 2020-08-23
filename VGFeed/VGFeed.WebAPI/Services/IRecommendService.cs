using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VGFeed.WebAPI.Services
{
    public interface IRecommendService<T>
    {
         List<Model.Igre> GetSlicni(int id);
    }
}
