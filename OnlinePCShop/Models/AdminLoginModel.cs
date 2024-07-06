using System.ComponentModel.DataAnnotations;

namespace OnlinePCShop.Models
{
    public class AdminLoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

