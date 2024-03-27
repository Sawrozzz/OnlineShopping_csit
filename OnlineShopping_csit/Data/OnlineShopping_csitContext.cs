using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping_csit.Models;

namespace OnlineShopping_csit.Data
{
    public class OnlineShopping_csitContext : DbContext
    {
        public OnlineShopping_csitContext (DbContextOptions<OnlineShopping_csitContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
    }
}
