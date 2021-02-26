using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class Customer:IdentityUser<int>
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }




    }

    public class CustomerRole : IdentityRole<int>
    {

    }
}
