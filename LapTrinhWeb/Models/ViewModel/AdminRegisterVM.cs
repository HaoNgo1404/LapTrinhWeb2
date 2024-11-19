﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LapTrinhWeb.Models.ViewModel
{
    public class AdminRegisterVM
    {
        [Required(ErrorMessage = "Hãy nhập tên đăng nhập.")]
        [Display(Name = "Tên dăng nhập")]
        [StringLength(15, ErrorMessage = "Tên đăng nhập không được quá 15 chữ.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu.")]
        [Display(Name = "Mật khẩu")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 đến 15 chữ.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Hãy xác nhận lại mật khẩu")]
        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận lại mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp.")]
        public string ConfirmPassword { get; set; }
    }
}