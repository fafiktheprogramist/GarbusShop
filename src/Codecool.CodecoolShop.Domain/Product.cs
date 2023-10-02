using System;
using System.ComponentModel.DataAnnotations;

namespace Codecool.CodecoolShop.Domain
{
    public class Product : BaseModel
    {
        public string Currency { get; set; }
        public decimal DefaultPrice { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Supplier Supplier { get; set; }

        public void SetProductCategory(ProductCategory productCategory)
        {
            ProductCategory = productCategory;
            ProductCategory.Products.Add(this);
        }

        public int ProductCategoryId { get; set; }

        public int SupplierId { get; set; }


        //internal Product find(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
