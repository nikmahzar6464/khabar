using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using DataLayer;
using Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shop.Areas.Admin.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Areas.Admin.Controllers
{
    //[Authorize(Roles ="Administrator")]
    [Area("Admin")]
    public class CustomerController : Controller
    {
       private readonly UserManager<Customer> userManager;
        private readonly RoleManager<CustomerRole> roleManager;
        private readonly IKhabarContext Context = null;

        public CustomerController(IKhabarContext _Context, UserManager<Customer> _userManager, RoleManager<CustomerRole> _roleManager)
        {
            this.Context = _Context;
            this.userManager = _userManager;
            this.roleManager = _roleManager;
        }

        public IActionResult Index()
        {
            return Redirect("/Admin/Customer/List");
        }
        [HttpGet]
        public IActionResult List()
        {
            var users = userManager.Users.ToList();
            List<CustomerRegisterModel> model = new List<CustomerRegisterModel>();
            foreach (var item in users)
            {
                model.Add(new CustomerRegisterModel()
                {
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Id = item.Id,
                    UserName = item.UserName
                });
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ManageRoles(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            var model = new ManageCustomeRoleModel();

            model.fullName = user.FirstName + " " + user.LastName;
            model.Id = user.Id.ToString();

            model.ListRoles = roleManager.Roles.ToList();

            foreach (var item in model.ListRoles)
            {
                if (await userManager.IsInRoleAsync(user, item.Name))
                {
                    model.AssignedRoles.Add(item);

                }
            }

            return View(model);
        }
       
        public async Task<IActionResult> SaveRole(string roleids, string userid)
        {
            if (roleids == null)
                return Ok();

            var listids = roleids.Split(";");
            var user = await userManager.FindByIdAsync(userid.ToString());
            var ListRoles = roleManager.Roles.ToList();
            foreach (var item in ListRoles)
            {

                if (listids.Contains(item.Id.ToString()))
                    await userManager.AddToRoleAsync(user, item.Name);
                else
                {
                   
                    await userManager.RemoveFromRoleAsync(user, item.Name);
                }

            }
            return Ok();
        }
    }
}
