using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataLayer;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        KhabarContext Context = new KhabarContext();


        public IActionResult Index()
        {

            return RedirectToAction("List");
        }




        #region Utilities
        [NonAction]
        private void PrepareListModel(Models.NewsListModel model)
        {
            var _listNews = Context.News.Where(p => (p.Title.Contains(model.NewsSearchName) || string.IsNullOrEmpty(model.NewsSearchName)) && (p.CategoryID == model.CategoryId || model.CategoryId == 0))
                .Select(p => new { CategoryName = p.Category.CatTitle, p.CategoryID, p.ID, p.Title, p.FullText, p.Image, UserFullName = p.User.FullName, p.UserID, }).ToList();

            foreach (var News in _listNews)
            {
                model.News.Add(new Models.NewsListModel.NewsListItem
                {
                    CategoryID = News.CategoryID,
                    CategoryName = News.CategoryName,

                    UserID = News.CategoryID,
                    UserFullName = News.UserFullName,



                    ID = News.ID,
                    Title = News.Title,
                    Image = News.Image,
                    FullText = News.FullText,


                });
            }
        }
        [NonAction]
        private void PrepareCategoriesModel(Models.NewsListModel model)
        {
            var _categories = Context.Categories.Select(p => new { p.CatTitle, p.ID }).ToList();
            model.Categories.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
            {
                Text = "--",
                Value = "0"
            });
            foreach (var item in _categories)
            {
                model.Categories.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Text = item.CatTitle,
                    Value = item.ID.ToString()
                });
            }
        }

        [NonAction]
        private void PrepareUsersModelNews(NewsModel model)
        {
            var Users = Context.Users.ToList();


            foreach (var item in Users)
            {
                model.Users.Add(new SelectListItem()
                {
                    Text = item.FullName,
                    Value = item.ID.ToString()
                });
            }

        }


        [NonAction]
        private void PrepareCategoryModelNews(NewsModel model)
        {
            var categories = Context.Categories.ToList();


            foreach (var item in categories)
            {
                model.Categories.Add(new SelectListItem()
                {
                    Text = item.CatTitle,
                    Value = item.ID.ToString()
                });
            }

        }

        #endregion


        public IActionResult List(Models.NewsListModel model)
        {
            PrepareListModel(model);
            PrepareCategoriesModel(model);

            return View(model);
        }


        [HttpGet]
        public IActionResult Create(int? id)
        {
            var model = new Models.NewsModel();
            if (id.HasValue)
            {
                var news = Context.News.Find(id);
                model.CategoryID = news.CategoryID;
                model.ID = news.ID;
               
                model.FullText = news.FullText;
                model.UserID = news.UserID;
                //model.Image = news.Image;
                model.Title = news.Title;

            }
            PrepareUsersModelNews(model);
            PrepareCategoryModelNews(model);
            return View(model);
        }


        [HttpPost]
        public IActionResult Create(NewsModel model)
        {

            if (ModelState.IsValid && ModelState.ErrorCount == 0)
            {
                Domains.News news = new Domains.News();
                news.ID = model.ID;
                news.CategoryID = model.CategoryID;
                
                news.FullText = model.FullText;
                //news.Image = model.Image;
                news.Title = model.Title;
                news.UserID = model.UserID;
                news.ID = model.ID;
                Context.Update(news);
                Context.SaveChanges();
                return RedirectToAction("List");
            }

            PrepareUsersModelNews(model);
            PrepareCategoryModelNews(model);
            return View(model);
        }

       
        }



    }


