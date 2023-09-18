using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Codecool.CodecoolShop.Models
{
    public class CheckoutModel : BaseModel
    {
        [BindProperty]
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; } = "";
        [BindProperty] public string LastName { get; set; } = "";
        [BindProperty] public string Email { get; set; } = "";
        [BindProperty] public string PhoneNumber { get; set; } = "";
        [BindProperty] public string CountryBill { get; set; } = "";
        [BindProperty] public string CityBill { get; set; } = "";
        [BindProperty] public string ZipCodeBill { get; set; } = "";
        [BindProperty] public string StreetBill { get; set; } = "";
        [BindProperty] public string NumberBill { get; set; } = "";
        [BindProperty] public string CountryShip { get; set; } = "";
        [BindProperty] public string CityShip { get; set; } = "";
        [BindProperty] public string ZipCodeShip { get; set; } = "";
        [BindProperty] public string StreetShip { get; set; } = "";
        [BindProperty] public string NumberShip { get; set; } = "";

        public string successMessage = "";
        public string errorMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!Codecool.CodecoolShop.Models.CheckoutModel.IsVali)
            {
                errorMessage = "Data validation failed";
                return;
            }
            successMessage = "Your checkout form has been received correctly.";

            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            CountryBill = "";
            CityBill = "";
            ZipCodeBill = "";
            StreetBill = "";
            NumberBill = "";
            CountryShip = "";
            CityShip = "";
            ZipCodeShip = "";
            StreetShip = "";
            NumberShip = "";

            ModelState.Clear();

        }

    }
}