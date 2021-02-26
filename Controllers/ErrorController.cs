using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        // GET: /<controller>/
        public IActionResult Generalerror(int? statusCode)
        {
            return View(statusCode);
        }
        public IActionResult Lockout(int? statusCode)
        {
            return View();
        }
    }
}
