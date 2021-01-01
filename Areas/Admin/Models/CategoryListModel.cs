using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class CategoryListModel
    {
        public CategoryListModel()
        {
            Categories = new List<Category>();
        }
        [Display(Name ="عنوان جستجو: ")]
        [Required(ErrorMessage ="لطفا عنوان را وارد کن")]
        public string CategorySearchName { get; set; }

        public List<Category> Categories { get; set; }
    }
}
