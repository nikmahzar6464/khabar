using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class User:BaseEntity
    {
        public string UserName { get; set; } 
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int NationalCode { get; set; }
        public int Mobile { get; set; }
        public int UserTypeID { get; set; }

        public UserType UserType { get; set; }
        public ICollection<News> News { get; set; }
        

        

    }

}
