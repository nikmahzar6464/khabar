using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace Khabar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PictureController : Controller
    {
        private readonly IHostingEnvironment hosting;
        public PictureController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AsyncUploadPicture()
        {
            var files = Request.Form.Files[0];
            if (!files.ContentType.Contains("image"))
                return new StatusCodeResult(403);

            string name = Guid.NewGuid().ToString();
            var path = Path.Combine(hosting.WebRootPath, "Pictures/" + name + ".jpg");

            if (files.Length > 0)
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await files.CopyToAsync(stream);
                }
            }

            return new OkObjectResult(new { id = name });
        }
    }
}
