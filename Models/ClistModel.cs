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
    public class CListModel
    {

        public CListModel()
        {
            news = new List<SelectListItem>();
            Users = new List<SelectListItem>();
        }


        [Display(Name = "عنوان کامنت: ")]
        public string CommentSearchName { get; set; }
        public int ID { get; set; }
        public string CommentName { get; set; }

        public int newsID { get; set; }
        public int UserID { get; set; }


        public IList<SelectListItem> news { get; set; }
        public IList<SelectListItem> Users { get; set; }


       
    }
}
