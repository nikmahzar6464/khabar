using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class NewsDetialModel
    {
        public NewsDetialModel()
        {
            ImageUrls = new List<string>();
            Comments = new List<CommentListForNews>();
        }

        public int ID { get; set; }

        public string FullText { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public int UserID { get; set; }
        public string UserLastName { get; set; }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<string> ImageUrls { get; set; }

        public string CustomerId { get; set; }
        public string CommentName { get; set; }
        public List<CommentListForNews> Comments { get; set; }
    }

    public class CommentListForNews
    {
        public string CommentName { get; set; }
        public string CustomerName { get; set; }
    }
}
