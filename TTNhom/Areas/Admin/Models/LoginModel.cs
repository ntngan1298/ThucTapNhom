﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TTNhom.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Mời bạn nhập tên tài khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mời bạn nhập mật khẩu")]
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }
    }
}