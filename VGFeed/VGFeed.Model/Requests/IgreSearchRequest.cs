using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class IgreSearchRequest
    {
        public string Naziv { get; set; }
        public int? PlatformaId { get; set; }
        public int? ZanrId { get; set; }

          

    }
}
