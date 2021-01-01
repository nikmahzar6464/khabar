using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domains;
using Khabar.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Models
{
    public class UserListModel
    {
        public UserListModel()
        {
            Users = new List<UserListItem>();
            UserTypes = new List<SelectListItem>();
            SearchName = "";

        }
        
        
        [Display(Name ="نام کاربر:")]
        public string UserSearchName { get; set; }
        public int UserTypeID { get; set; }
        public List<UserListItem> Users { get; }
        public IList<SelectListItem> UserTypes { get; set; }
        public string SearchName { get; set; }

        public class UserListItem
        {
            public int ID { get; set; }
            public string UserName { get; set; }
            public string PassWord { get; set; }
            public string FullName { get; set; }
            public int NationalCode { get; set; }
            public int Mobile { get; set; }
            public string Email { get; set; }
            public int UserTypeID { get; set; }
            public string UserTypeName { get; set; }
        }
    }

}
