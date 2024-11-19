using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LapTrinhWeb.Models.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Hãy nhập Tên đăng nhập.")]
        [Display(Name = "Tên dăng nhập")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hãy nhập Mật khẩu.")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}