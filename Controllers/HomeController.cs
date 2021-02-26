using System.Linq;
using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;


namespace Khabar.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private SqlServerKhabarContext _context;

        public HomeController(SqlServerKhabarContext context)
        {
            _context = context;
        }


        #region Utilities
        [NonAction]
        private void PrepareListModel(Models.MlistModel model)
        {
            var _listNews = _context.News.ToList();

            foreach (var News in _listNews)
            {
                model.News.Add(new Models.MlistModel.mNewsListItem
                {
                    CategoryID = News.CategoryID,
                    UserID = News.CategoryID,
                    //UserFullName = News.UserFullName,



                    ID = News.ID,
                    Title = News.Title,
                    Image = News.Imageurl,
                    FullText = News.FullText,


                });
            }
        }
        [NonAction]
        private void PrepareCategoriesModel(Models.MlistModel model)
        {
            var _categories = _context.Categories.Select(p => new { p.CatTitle, p.ID }).ToList();
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




        #endregion


        #region Index
        public IActionResult Index()
        {
            var latestNews = _context.News.OrderByDescending(x => x.CreationDate).ToList();
            HomeNewsModel model = new HomeNewsModel();
            model.LatestNews = latestNews;
            return View("Index", model);
        }

        #endregion





        [HttpGet]
        public IActionResult HomeNewss()
        {
            var news = _context.News.Select(p => new { p.ID, p.Title, p.FullText, p.Imageurl, categoryname = p.Category.CatTitle, p.Pictures.FirstOrDefault().picturesId, p.CategoryID }).ToList();
            var model = new Models.HomeNewsModel();
            foreach (var newses in news)
            {
                model.CategoryID = newses.CategoryID;
                model.newslist.Add(new Models.NewssItemModel()
                {
                    ID = newses.ID,
                    Title = newses.Title,
                    FullText = newses.FullText,
                    ImageUrl = $"/Pictures/{newses.picturesId}.jpg"
                });
            }


            return View(model);
        }

        public IActionResult Comment(Models.MlistModel model)
        {

            PrepareListModel(model);
            PrepareCategoriesModel(model);

            return View(model);
        }
    }
}
