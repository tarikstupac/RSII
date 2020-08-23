using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
    public class Platforme
    {
        public int PlatformId { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public byte[] Logo { get; set; }
    }
}
