using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Models
{
    public class NewsModel
    {
        public NewsModel()
        {
            Users = new List<SelectListItem>();
            Categories = new List<SelectListItem>();
        }

        public int ID { get; set; }

        [Display(Name = "موضوع")]
        public int CategoryID { get; set; }


        [Display(Name = "متن خبر")]
        public string FullText { get; set; }


        [Display(Name = "تصویر")]
        public string Image { get; set; }


        [Display(Name = "عنوان")]
        public string Title { get; set; }


        [Display(Name = "نویسنده")]
        public int UserID { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImgFile { get; set; }

        public string ImgAddress { get; set; }

        public IList<SelectListItem> Users { get; set; }
        
        public IList<SelectListItem> Categories { get; set; }
    }
}
