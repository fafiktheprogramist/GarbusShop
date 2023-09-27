using Codecool.CodecoolShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Data
{
    public class ProductsContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-FLUTGQS\\SQLEXPRESS;Database=Products;Integrated Security=true;TrustServerCertificate=true";
        
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
