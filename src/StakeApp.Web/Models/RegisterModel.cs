using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StakeApp.Web.Models
{
    public class RegisterModel
    {
        [DisplayName("Name")]
        [Required]
        public string FullName { get; set;}
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Email Address")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
 
    }
}