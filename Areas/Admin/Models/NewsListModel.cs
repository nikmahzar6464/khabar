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
    public class NewsListModel
    {
        public NewsListModel()
        {
            News = new List<NewsListItem>();
            Categories = new List<SelectListItem>();
            Users = new List<SelectListItem>();
            SearchName = "";

        }


        [Display(Name = "عنوان جستجو: ")]
        public string NewsSearchName { get; set; }

        public string SearchName { get; set; }

        [Display(Name ="موضوع خبر")]
        public int CategoryId { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }
        public IList<NewsListItem> News { get; set; }
        public IList<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Users { get; set; }


        public class NewsListItem
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Image { get; set; }
            public string FullText { get; set; }


            public int CategoryID { get; set; }

            public string CategoryName { get; set; }

            public int UserID { get; set; }
            public string UserFullName { get; set; }


        }
    }
}
