using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Platforme
    {
        public Platforme()
        {
            Igre = new HashSet<Igre>();
        }

        public int PlatformId { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public byte[] Logo { get; set; }

        public ICollection<Igre> Igre { get; set; }
    }
}
