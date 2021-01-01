using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class News:BaseEntity
    {
        public string Title { get; set; }
        public string FullText { get; set; }
        public string Image { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }


        public Category Category { get; set; }
        public User User { get; set; }
       

    }
}
