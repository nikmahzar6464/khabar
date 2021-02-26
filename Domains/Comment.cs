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
        public int CustomerID { get; set; }
        public int NewsID { get; set; }


        
        public News newses { get; set; }
        public Customer Customer { get; set; }
        

        public ICollection <Customer> Customers { get; set; }
        
    }
}