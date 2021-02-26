using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class NewsCategoryModel
    {
        public NewsCategoryModel()
        {
            newslist = new List<NewsItemModel>();
        }

        public int UserID { get; set; }
        public string UserLastName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<NewsItemModel> newslist { get; set; }
    }

    public class NewsItemModel
    {
        public int ID { get; set; }
        public string FullText { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
