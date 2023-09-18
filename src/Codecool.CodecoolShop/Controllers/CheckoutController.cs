using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Helpers;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.CodecoolShop.Controllers
{
    // [Route("checkout")]
    public class CheckoutController : Controller
    {
        public ProductService ProductService { get; set; }

        
        // [Route("checkout")]
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
