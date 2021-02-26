using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace Khabar.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IKhabarContext Context = null;

        public CategoryController(IKhabarContext _Context)
        {
            this.Context = _Context;
        }

        public IActionResult Index()
        {
            return Redirect("/Admin/Category/List");
        }

        [HttpGet]
        public IActionResult List(CategoryListModel model)
        {
            if (string.IsNullOrEmpty(model.CategorySearchName))
                model.CategorySearchName = "";
            

            model.Categories = Context.Categories.Where(p => p.CatTitle.Contains(model.CategorySearchName)).ToList();
            return View(model);
        }


        
        [HttpGet]
        public IActionResult Create(int? id)
        {
            Models.CategoryModel model = new CategoryModel();
            if (id.HasValue)
            {
                var Category = Context.Categories.Find(id);
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
            Context.Categories.Update(category);
            Context.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {

            var Category = Context.Categories.Find(id);
            Context.Remove(Category);
            Context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
