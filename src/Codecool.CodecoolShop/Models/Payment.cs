using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codecool.CodecoolShop.Models
{
    public class Payment
    {
        [Required(ErrorMessage = "The card number is required")]
        [StringLength(16)]
        public string CardNumber { get; set; } = "";

        [Required(ErrorMessage = "The name is required")]
        [StringLength(10)]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "The expiry date is required")]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "The CVV is required")]
        [StringLength(3)]
        public string Cvv { get; set; } = "";

      
    }
}

