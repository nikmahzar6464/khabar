using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel
    {
        public UserModel()
        {
            UserTypes = new List<SelectListItem>();
        }


        public int ID { get; set; }

        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Display(Name = "رمز عبور")]
        public string PassWord { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }

        [Display(Name = "کد ملی")]
        public int NationalCode { get; set; }

        [Display(Name = "موبایل")]
        public int Mobile { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "نوع کاربر")]
        public int UserTypeID { get; set; }
        public IList<SelectListItem> UserTypes { get; set; }
    }
}
