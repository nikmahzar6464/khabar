using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class Category: BaseEntity
    {

        
        public string CatTitle { get; set; }
        public string Description { get; set; }

        public ICollection<News> Newses { get; set; }
    }
}
