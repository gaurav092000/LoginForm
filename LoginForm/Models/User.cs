using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginForm.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName required")]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName required")]
        [DisplayName("LastName")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Gender required")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "age required")]
        [DisplayName("Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Email required")]
        [DisplayName("Email")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName required")]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "ConfirmPassword required")]
        [DisplayName("ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ComfirmPassword { get; set; } 

    }
}