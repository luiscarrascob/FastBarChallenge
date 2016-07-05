using System;
using System.ComponentModel.DataAnnotations;

namespace FastBar.Models
{
    public class StripeTokenModel
    {
        [Required]
        public string Token { get; set; }
    }
}