using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Domains;
using Microsoft.AspNetCore.Identity;
using System.Data.Entity;
using Models;

namespace Khabar.Areas.Admin.Controllers
{
    public class UserRolesController : Controller
    {

        private readonly UserManager<Customer> _userManager;
        private readonly RoleManager<CustomerRole> _roleManager;


        public UserRolesController(UserManager<Customer> userManager, RoleManager<CustomerRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (Customer user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.UserName;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }
        private async Task<List<string>> GetUserRoles(Customer user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }
    }

}

