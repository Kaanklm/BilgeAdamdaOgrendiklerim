using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Kullanıcı adı gerekli!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre gerekli!")]
        public string Password { get; set; }
    }
}