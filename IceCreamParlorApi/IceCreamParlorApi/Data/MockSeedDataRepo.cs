using IceCreamParlorApi.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Data
{
    public class MockSeedDataRepo : IParlorRepo
    {
        public IEnumerable<IceCream> GetAllItems()
        {
            //ice cream flavors : Winter Chocolate, Caramel Cheesecake, Chocolate, Cotton Candy
            var icecreams = new List<IceCream>
            {
                new IceCream(1,
                            "Winter Chocolate",
                            DateTime.TryParseExact("1/1/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,out DateTime Di) ? Di :null,
                            (decimal)5.75)
            };
            return icecreams;
        }
        //Shape : Square, Round, Rectangle, Roll
        //Size: two-third, half, one-sixth, one-third sheet, six inch, nine inch roll, half roll, full roll
        //Flavor: Chocolate cake -Pralines cream, Vanilla cake - Chocolate chip, Chocolate cake - Oreo cookies n cream,
    }
}
