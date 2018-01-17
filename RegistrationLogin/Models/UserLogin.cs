using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationLogin.Models
{
    public class UserLogin
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Id Required")]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}