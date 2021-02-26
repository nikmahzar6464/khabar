using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domains
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string FullText { get; set; }
        public string Imageurl { get; set; }
        public int UserId { get; set; }
        public int CategoryID { get; set; }
        public DateTime? CreationDate { get; set; }

        public Category Category { get; set; }
        public Customer user { get; set; }

        public virtual ICollection<NewsPicture> Pictures { get; set; }
    }

    public class NewsPicture : BaseEntity
    {
        public int NewsID { get; set; }
        public string picturesId { get; set; }
        public News News { get; set; }
    }


}
