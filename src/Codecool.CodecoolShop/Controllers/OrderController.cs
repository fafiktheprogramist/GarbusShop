using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Helpers;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace Codecool.CodecoolShop.Controllers
{
    public class OrderController : Controller
    {

        [HttpPost]
        public IActionResult Order(CheckoutModel checkoutModel)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.DefaultPrice * item.Quantity);
            }

            OrderModel orderDetails = new OrderModel(checkoutModel.Id, checkoutModel.FirstName, checkoutModel.LastName, checkoutModel.Email, checkoutModel.PhoneNumber,
            checkoutModel.CountryBill, checkoutModel.CityBill, checkoutModel.ZipCodeBill, checkoutModel.StreetBill, checkoutModel.NumberBill,
            checkoutModel.CountryShip, checkoutModel.CityShip, checkoutModel.ZipCodeShip, checkoutModel.StreetShip, checkoutModel.NumberShip);
            ViewBag.OrderDetails = orderDetails.GetOrderDetails();
            string json1 = JsonConvert.SerializeObject(cart.ToString());
            string json2 = JsonConvert.SerializeObject(orderDetails.ToString());
            Console.WriteLine(json1);
            Console.WriteLine(json2);
            //System.IO.File.WriteAllText(@"E:\programowanie\projekty\C#\koszyk\irytujacyKoszyk.json", json1);
            //System.IO.File.WriteAllText(@"E:\programowanie\projekty\C#\koszyk\irytujacyKoszyk.json", json2);

            return View();
        }
    }
}
