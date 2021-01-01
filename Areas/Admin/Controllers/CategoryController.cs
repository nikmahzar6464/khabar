using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Models;

namespace Khabar.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        KhabarContext KhabarContext = new KhabarContext();


        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List(CategoryListModel model)
        {
            if (string.IsNullOrEmpty(model.CategorySearchName))
                model.CategorySearchName = "";

            model.Categories = KhabarContext.Categories.Where(p => p.CatTitle.Contains(model.CategorySearchName)).ToList();
            return View(model);
        }



        [HttpGet]
        public IActionResult Create(int? id)
        {
            Models.CategoryModel model = new CategoryModel();
            if (id.HasValue)
            {
                var Category = KhabarContext.Categories.Find(id);
                if (Category != null)
                {
                    model.Description = Category.Description;
                    model.ID = Category.ID;
                    model.Name = Category.CatTitle;
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Models.CategoryModel model)
        {
            Domains.Category category = new Domains.Category();
            category.Description = model.Description;
            category.CatTitle = model.Name;
            category.ID = model.ID;
            KhabarContext.Categories.Update(category);
            KhabarContext.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {

            var Category = KhabarContext.Categories.Find(id);
            KhabarContext.Remove(Category);
            KhabarContext.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
