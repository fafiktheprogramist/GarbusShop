using System.Collections.Generic;

namespace Codecool.CodecoolShop.Domain
{
    public class ProductCategory : BaseModel
    {
        public List<Product> Products { get; set; }
        public string Department { get; set; }
    }
}
