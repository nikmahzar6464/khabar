using Domains;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public class MyIdentityDataInitializer
    {
        public static void SeedData(UserManager<Customer> userManager, RoleManager<CustomerRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedRoles(roleManager);
        }

        public static void SeedUsers(UserManager<Customer> userManager)
        {
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                Customer user = new Customer();
                user.UserName = "Admin";
                user.Email = "Admin@yahoo.com";
                user.FirstName = "Morteza";
                user.LastName = "ghasemi";

                IdentityResult result = userManager.CreateAsync(user, "Aa123#").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                                        "Administrator").Wait();
                }
            }


       

        }

        public static void SeedRoles(RoleManager<CustomerRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Registred").Result)
            {
                CustomerRole role = new CustomerRole();
                role.Name = "Registred";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                CustomerRole role = new CustomerRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
