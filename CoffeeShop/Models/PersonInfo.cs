using System;
using System.ComponentModel.DataAnnotations;
namespace CoffeeShop.Models
{
    public class PersonModel
    {
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0 - 9a - zA - Z][-\w] *[0 - 9a - zA - Z] *\.)+[a-zA-Z0-9]{2,17})$")]
        public string PhoneNumber { get; set; }

        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string Password { get; set; }
    }
}
