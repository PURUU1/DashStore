using System.ComponentModel.DataAnnotations;

namespace DashStore.Models
{
    public class CreditCardModel
    {
        
            //[Required, Display(Name = "Cardholder Name")]
            //public string CardHolderName { get; set; }

            //[Required, CreditCard] 
            //public string CardNumber { get; set; }

            //[Required, Range(1, 12)]
            //public int ExpirationMonth { get; set; }

            //[Required, Range(2024, 2035)]
            //public int ExpirationYear { get; set; }

            //[Required, StringLength(4, MinimumLength = 3)]
            //public string CVV { get; set; }


        [Required(ErrorMessage = "Cardholder name is required")]
        public string CardHolderName { get; set; }

        [Required]
        [CreditCard(ErrorMessage = "Invalid credit card number")]
        public string CardNumber { get; set; }
        
        [Required(ErrorMessage = "Expiration date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/([0-9]{2})$", ErrorMessage = "Expiration date must be in MM/YY format")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "CVV is required")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV must be exactly 3 digits")]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "CVV must be exactly 3 numeric digits")]
        public string CVV { get; set; }


    }
}
