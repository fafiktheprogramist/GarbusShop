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

namespace Codecool.CodecoolShop.Controllers
{
    public class OrderController : Controller
    {
        //[HttpGet]
        public IActionResult Order(int id, string firstname, string lastname, string email, string phonenumber,
            string countrybill, string citybill, string zipcodebill, string streetbill, string numberbill,
            string countryship, string cityship, string zipcodeship, string streetship, string numbership)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.DefaultPrice * item.Quantity);
            }
            return View();
        }

        // [httppost]
        //public IActionresult Order(int id, string firstname, string lastname, string email, string phonenumber,
        //    string countrybill, string citybill, string zipcodebill, string streetbill, string numberbill,
        //    string countryship, string cityship, string zipcodeship, string streetship, string numbership)
        //{
        //    list<item> cart = sessionhelper.getobjectfromjson<list<item>>(httpcontext.session, "cart");

        //    return view();
        //}
    }
}
