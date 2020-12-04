using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Models
{
    public record Cake(int Id,
                        [Required] string Shape,
                        [Required] string Size,
                        [Required] string Flavor,
                        DateTime DateIntroduced,
                        [Required] decimal Price);
}
