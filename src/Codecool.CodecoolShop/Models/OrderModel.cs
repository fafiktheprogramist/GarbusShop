using System.Data.Common;

namespace Codecool.CodecoolShop.Models
{
    public class OrderModel
    {
        private int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        private string CountryBill { get; set; }
        private string CityBill { get; set; }
        private string ZipCodeBill { get; set; }
        private string StreetBill { get; set; }
        private string NumberBill { get; set; }
        public string CountryShip { get; set; }
        public string CityShip { get; set; }
        public string ZipCodeShip { get; set; }
        public string StreetShip { get; set; }
        public string NumberShip { get; set; }
        public OrderModel(int id, string firstName, string lastName, string email, string phoneNumber,
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
