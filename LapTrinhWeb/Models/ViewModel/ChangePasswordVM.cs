
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LapTrinhWeb.Models.ViewModel
{
    public class ChangePasswordVM
    {
        public string Username { get; set; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu hiện tại")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu mới")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 đến 15 chữ.")]
        [Display(Name = "Mật khẩu mới")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Hãy xác nhận lại mật khẩu mới")]
        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận lại mật khẩu mới")]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu không trùng khớp.")]
        public string ConfirmPassword { get; set; }
    }
}