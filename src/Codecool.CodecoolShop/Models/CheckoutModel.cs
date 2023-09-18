using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Codecool.CodecoolShop.Models
{
    public class CheckoutModel : BaseModel
    {
        
        [Required(ErrorMessage = "The first name is required")]
        [StringLength(20)]

        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "The last name is required")]
        [StringLength(20)]
        public string LastName { get; set; } = "";
        
        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "The phone number is required")]
        [Phone]
        public string PhoneNumber { get; set; } = "";

        [StringLength(20)]
        public string CountryBill { get; set; } = "";

        [StringLength(20)]
        public string CityBill { get; set; } = "";

        [StringLength(6)]
        public string ZipCodeBill { get; set; } = "";

        [StringLength(20)]
        public string StreetBill { get; set; } = "";

        [StringLength(5)]
        public string NumberBill { get; set; } = "";

        [Required(ErrorMessage = "The country is required")]
        [StringLength(20)]
        public string CountryShip { get; set; } = "";
        [Required(ErrorMessage = "The city is required")]
        [StringLength(20)]
        public string CityShip { get; set; } = "";

        [Required(ErrorMessage = "The zip code is required")]
        [StringLength(6)]
        public string ZipCodeShip { get; set; } = "";

        [Required(ErrorMessage = "The street is required")]
        [StringLength(20)]
        public string StreetShip { get; set; } = "";
        [Required(ErrorMessage = "The number is required")]
        [StringLength(5)]
        public string NumberShip { get; set; } = "";

        public string successMessage { get; set; } = "Validation success!"; 
        public string errorMessage { get; set; } = "Validation failure!";



    }
}