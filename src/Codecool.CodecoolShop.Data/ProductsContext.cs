using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Data
{
    public class ProductsContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-FLUTGQS;Database=Products;Integrated Security=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
