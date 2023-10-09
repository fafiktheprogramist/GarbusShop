using Codecool.CodecoolShop.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Codecool.CodecoolShop.Models
{
    public class Item : Product
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Item()
        {
        }
    }
}
