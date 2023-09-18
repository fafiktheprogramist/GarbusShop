using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Codecool.CodecoolShop.Models
{
    public class CheckoutModel : BaseModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string CountryBill { get; set; } = "";
        public string CityBill { get; set; } = "";
        public string ZipCodeBill { get; set; } = "";
        public string StreetBill { get; set; } = "";
        public string NumberBill { get; set; } = "";
        public string CountryShip { get; set; } = "";
        public string CityShip { get; set; } = "";
        public string ZipCodeShip { get; set; } = "";
        public string StreetShip { get; set; } = "";
        public string NumberShip { get; set; } = "";

    }
}
