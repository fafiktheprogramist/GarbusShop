using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Codecool.CodecoolShop.Models
{
    public class CheckoutModel : BaseModel
    {
        [Required(ErrorMessage = "The first name is required")]
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

        public string successMessage = "";
        public string errorMessage = "";

        public bool IsValid()
        {
            return true;
        }

        public void Clear()
        {
            
        }
        public void OnGet()
        {
        }

        //public void OnPost()
        //{
        //    if (!ModelState.)
        //    {
        //        errorMessage = "Data validation failed";
        //        return;
        //    }
        //    successMessage = "Your checkout form has been received correctly.";

        //    FirstName = "";
        //    LastName = "";
        //    PhoneNumber = "";
        //    CountryBill = "";
        //    CityBill = "";
        //    ZipCodeBill = "";
        //    StreetBill = "";
        //    NumberBill = "";
        //    CountryShip = "";
        //    CityShip = "";
        //    ZipCodeShip = "";
        //    StreetShip = "";
        //    NumberShip = "";

        //    Codecool.CodecoolShop.Models.CheckoutModel.Clear();

        //}

    }
}