using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;

namespace Domains
{
    public class UserType:BaseEntity
    {
        public string UserTypeName { get; set; }

        
        public ICollection<User> Users { get; set; }
    }
}
