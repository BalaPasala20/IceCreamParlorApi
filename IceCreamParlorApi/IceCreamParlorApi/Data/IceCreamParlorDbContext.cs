using IceCreamParlorApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Data
{
    public class IceCreamParlorDbContext : DbContext
    {
        public IceCreamParlorDbContext(DbContextOptions<IceCreamParlorDbContext> options): base (options)
        {

        }
        public DbSet<IceCream> IceCreams { get; set; }
    }
}
