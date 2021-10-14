using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_ORM.Data.Models
{
    class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Integrted Sequrity = true; Database=ProductDb");
        }
        public DbSet<Product> Products { get; set; }
    }
}
