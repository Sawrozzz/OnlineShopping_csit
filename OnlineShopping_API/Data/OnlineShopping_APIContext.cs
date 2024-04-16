using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping_API.Models;

namespace OnlineShopping_API.Data
{
    public class OnlineShopping_APIContext : DbContext
    {
        public OnlineShopping_APIContext (DbContextOptions<OnlineShopping_APIContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShopping_API.Models.Category> Category { get; set; } = default!;
        public DbSet<OnlineShopping_API.Models.Product> Product { get; set; } = default!;
    }
}
