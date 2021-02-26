using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(person person)
        {

            return new EmptyResult();
        }

    }
    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
