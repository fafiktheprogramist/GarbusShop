using System.Collections.Generic;
using System;
using System.Data.Common;

namespace Codecool.CodecoolShop.Models
{
    public class OrderModel
    {

        private Dictionary<string, string> OrderDetails = new Dictionary<string, string>();

        public OrderModel(int id, string firstName, string lastName, string email, string phoneNumber,
            string countryBill, string cityBill, string zipCodeBill, string streetBill, string numberBill,
            string countryShip, string cityShip, string zipCodeShip, string streetShip, string numberShip)
        {
            OrderDetails.Add("Id", id.ToString());
            OrderDetails.Add("FirstName", firstName);
            OrderDetails.Add("LastName", lastName);
            OrderDetails.Add("Email", email);
            OrderDetails.Add("PhoneNumber", phoneNumber);
            OrderDetails.Add("CountryBill", countryBill);
            OrderDetails.Add("CityBill", cityBill);
            OrderDetails.Add("ZipCodeBill", zipCodeBill);
            OrderDetails.Add("StreetBill", streetBill);
            OrderDetails.Add("NumberBill", numberBill);
            OrderDetails.Add("CountryShip", countryShip);
            OrderDetails.Add("CityShip", cityShip);
            OrderDetails.Add("ZipCodeShip", zipCodeShip);
            OrderDetails.Add("StreetShip", streetShip);
            OrderDetails.Add("NumberShip", numberShip);
        }

        public Dictionary<string, string> GetOrderDetails()
        {
            return OrderDetails;
        }
    }
}
