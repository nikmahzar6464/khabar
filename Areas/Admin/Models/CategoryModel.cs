using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        [Display(Name="عنوان")]
        public string Name { get; set; }
        [Display(Name = "شرح")]
        public string Description { get; set; }
    }
}
