using System.Collections.Generic;
using System;
using System.Data.Common;

namespace Codecool.CodecoolShop.Models
{
    public class OrderModel
    {

        private Dictionary<string, string> OrderDetails;

        public OrderModel(int id, string firstName, string lastName, string email, string phoneNumber,
            string countryBill, string cityBill, string zipCodeBill, string streetBill, string numberBill,
            string countryShip, string cityShip, string zipCodeShip, string streetShip, string numberShip)
        {
            OrderDetails = new Dictionary<string, string>
            {
                { "Id", id.ToString() },
                { "FirstName", firstName },
                { "LastName", lastName },
                { "Email", email },
                { "PhoneNumber", phoneNumber },
                { "CountryBill", countryBill },
                { "CityBill", cityBill },
                { "ZipCodeBill", zipCodeBill },
                { "StreetBill", streetBill },
                { "NumberBill", numberBill },
                { "CountryShip", countryShip },
                { "CityShip", cityShip },
                { "ZipCodeShip", zipCodeShip },
                { "StreetShip", streetShip },
                { "NumberShip", numberShip }
            };
        }
        public OrderModel()
        {
            
        }
        public Dictionary<string, string> GetOrderDetails()
        {
            return OrderDetails;
        }
    }
}
