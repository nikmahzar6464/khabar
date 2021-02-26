using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;

namespace Models
{
    public class HomeNewsModel
    {
        public HomeNewsModel()
        {

            newslist = new List<NewssItemModel>();
            LatestNews = new List<News>();

        }
        public int UserID { get; set; }
        public string UserLastName { get; set; }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<NewssItemModel> newslist { get; set; }
        public List<News> LatestNews { get; set; }
    }

    public class NewssItemModel
    {
        public int ID { get; set; }

        public string FullText { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }


    }


}
