using System;

namespace FastBar.Models
{
    public class CreditCardModel
    {
        public string Token { get; set; }

        public string CardHolderName { get; set; }
        
        public string CardNumber { get; set; }
        
        public string Cvc { get; set; }
        
        public string ExpirationMonth { get; set; }
        
        public string ExpirationYear { get; set; }

        public Boolean hasCard { get; set; }

        public String CreditCardType { get; set; }
        
    }
}