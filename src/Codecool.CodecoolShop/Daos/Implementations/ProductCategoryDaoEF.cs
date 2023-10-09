using Codecool.CodecoolShop.Data;
using Codecool.CodecoolShop.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.CodecoolShop.Daos.Implementations
{
    public class ProductCategoryDaoEF : IProductCategoryDao
    {
        private readonly ShopContext context;

        public ProductCategoryDaoEF(ShopContext context)
        {
            this.context = context;
        }
        public void Add(ProductCategory item)
        {
            throw new System.NotImplementedException();
        }

        public ProductCategory Get(int id)
        {
            return context.ProductCategories.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return context.ProductCategories.ToList();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
