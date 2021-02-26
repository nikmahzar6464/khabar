using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CommentsModel
    {
        public int ID { get; set; }
        public string CommentName { get; set; }
        public int CustomerID { get; set; }
        public int NewsID { get; set; }

    }
}
