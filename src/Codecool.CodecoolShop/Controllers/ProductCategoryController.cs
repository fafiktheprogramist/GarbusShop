using Codecool.CodecoolShop.Daos;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryDao dao;

        public ProductCategoryController(IProductCategoryDao dao)
        {
            this.dao = dao;
        }
        public ActionResult Index()
        {
            var productCategories = dao.GetAll();
            return View(productCategories);
        }
    }
}
