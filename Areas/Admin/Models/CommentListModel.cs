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
    public class CommentListModel
    {

        public CommentListModel()
        {
            Comments = new List<CommentListItem>();
            news = new List<SelectListItem>();
            Users = new List<SelectListItem>();
            SearchName = "";

        }


        [Display(Name = "عنوان کامنت: ")]
        public string CommentSearchName { get; set; }

        public string SearchName { get; set; }

        public int newsID { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }

        public List<CommentListItem> Comments { get; set; }
        public IList<SelectListItem> news { get; set; }
        public IList<SelectListItem> Users { get; set; }


        public class CommentListItem
        {
            public int ID { get; set; }
            public string CommentName { get; set; }

            public int NewsID { get; set; }

            public string NewsTitle { get; set; }

            public int UserID { get; set; }
            public string UserFullName { get; set; }
        }
    }
}
