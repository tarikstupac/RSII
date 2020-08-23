using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model.Requests;

namespace VGFeed.WebAPI.Services
{
    public interface IPorukeService
    {
        Model.Poruke Insert(PorukeInsertRequest request);
        Model.Poruke Update(int id, PorukeInsertRequest request);
        List<Model.Poruke> Get(PorukeSearchRequest search);
    }
}
