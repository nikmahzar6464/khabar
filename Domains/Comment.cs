using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class Comment : BaseEntity
    {
        public string CommentName { get; set; }
        public int UserID { get; set; }
        public int NewsID { get; set; }


        public User User { get; set; }
        public News newses { get; set; }
        
        public ICollection<News> news { get; set; }
        
    }
}