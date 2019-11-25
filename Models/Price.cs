using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sansonEdu001.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public int ProductId { get; set; }
        public decimal Value { get; set; }
        public string Supplier { get; set; }

    }
}
