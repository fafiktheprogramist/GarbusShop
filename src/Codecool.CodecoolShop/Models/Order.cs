using System.Data.Common;

namespace Codecool.CodecoolShop.Models
{
    public class Order
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email {  get; set; }
        private string PhoneNumber { get; set; }
        private string CountryBill { get; set; }
        private string CityBill { get; set; }    
        private string ZipCodeBill { get; set; }
        private string StreetBill { get; set; }
        private string NumberBill { get; set; }
        private string CountryShip { get; set; }
        private string CityShip { get; set; }
        private string ZipCodeShip { get; set; }
        private string StreetShip { get; set; }
        private string NumberShip { get; set; }
        public Order(int id, string firstName, string lastName, string email, string phoneNumber, 
            string countryBill, string cityBill, string zipCodeBill, string streetBill, string numberBill, 
            string countryShip, string cityShip, string zipCodeShip, string streetShip, string numberShip)
        {
            Id = id;
            FirstName = firstName; 
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            CountryBill = countryBill;
            CityBill = cityBill;
            ZipCodeBill = zipCodeBill;
            StreetBill = streetBill;
            NumberBill = numberBill;
            CountryShip = countryShip;
            CityShip = cityShip;
            ZipCodeShip = zipCodeShip;
            StreetShip = streetShip;
            NumberShip = numberShip;

        }
    }
}
