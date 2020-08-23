using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Store
    {
        public Store()
        {
            Sale = new HashSet<Sale>();
        }

        public int StoreId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Link { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}
