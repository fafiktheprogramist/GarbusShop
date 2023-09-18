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
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult OrderConfirmation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderConfirmation(int id, string firstName, string lastName, string email, string phoneNumber,
            string countryBill, string cityBill, string zipCodeBill, string streetBill, string numberBill,
            string countryShip, string cityShip, string zipCodeShip, string streetShip, string numberShip)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            return View();
        }
    }
}
