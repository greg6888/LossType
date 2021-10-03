using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LossType.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The username is required.")]
        [DisplayName("UserName")]

        public string userName { get; set; }
        [Required(ErrorMessage = "The password is required.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}