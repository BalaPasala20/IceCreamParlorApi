using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Models
{
    public class ParlorItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Flavor { get; set; }
        public DateTime IntroducedDate { get; set; }
        public decimal Price { get; set; }

    }
}
