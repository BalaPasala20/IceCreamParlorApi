using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Models
{
    public class ParlorItem
    {
        public int Id { get; set; }
        public string Type { get; set; } //icecream, sundae, beverage,cakes
        public string Flavor { get; set; }//ice cream flavors : Winter Chocolate, Caramel Cheesecake, Chocolate, Cotton Candy
        public DateTime IntroducedDate { get; set; }
        public decimal Price { get; set; }

    }
}
