using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using DataLayer;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private SqlServerKhabarContext _context;
        private string _imageFolderPath = "wwwroot\\Images\\News";

        public NewsController(SqlServerKhabarContext context)
        {
            _context = context;
        }


        #region Index

        public IActionResult Index()
        {
            return Redirect("/Admin/News/List");
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create(int? id)
        {
            var model = new NewsModel();
            if (id.HasValue)
            {
                var news = _context.News.Find(id);
                model.CategoryID = news.CategoryID;
                model.ID = news.ID;
                model.FullText = news.FullText;
                model.UserID = news.UserId;
                //model.Image = news.Image;
                model.Title = news.Title;
                model.ImgAddress = news.Imageurl;
            }

            PrepareCategoryModelNews(model);
            PrepareUserModel(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(NewsModel model)
        {
            if (ModelState.IsValid && ModelState.ErrorCount == 0)
            {
                if (model.ID == 0) //Create Mode
                {
                    var news = new News()
                    {
                        Title = model.Title,
                        FullText = model.FullText,
                        UserId = model.UserID,
                        CategoryID = model.CategoryID,
                        CreationDate = DateTime.Now
                    };

                    #region Save Image

                    if (model.ImgFile != null)
                    {
                        var imgAddress = model.ImgFile.FileName + Path.GetExtension(model.ImgFile.FileName);
                        var imagePath = Path.Combine(Directory.GetCurrentDirectory(), _imageFolderPath, imgAddress);
                        if (System.IO.File.Exists(imagePath))
                            System.IO.File.Delete(imagePath);

                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            model.ImgFile.CopyTo(stream);
                        }

                        news.Imageurl = imgAddress;
                    }

                    #endregion

                    _context.News.Add(news);
                }
                else //Update Mode
                {
                    var news = _context.News.Find(model.ID);
                    if (news != null)
                    {
                        news.Title = model.Title;
                        news.FullText = model.FullText;
                        news.CategoryID = model.CategoryID;
                        news.UserId = model.UserID;

                        if (model.ImgFile != null)
                        {
                            string imagePath;
                            if (!string.IsNullOrEmpty(model.ImgAddress))
                            {
                                imagePath = Path.Combine(Directory.GetCurrentDirectory(), _imageFolderPath, model.ImgAddress);
                                if (System.IO.File.Exists(imagePath))
                                    System.IO.File.Delete(imagePath);
                            }
                            else
                            {
                                imagePath = Path.Combine(Directory.GetCurrentDirectory(), _imageFolderPath, model.ImgFile.FileName);
                            }


                            using (var stream = new FileStream(imagePath, FileMode.Create))
                            {
                                model.ImgFile.CopyTo(stream);
                            }

                            news.Imageurl = model.ImgFile.FileName;
                            news.CreationDate = DateTime.Now;
                        }
                        _context.News.Update(news);
                    }
                }

                _context.SaveChanges();
                return RedirectToAction("List");
            }

            PrepareUserModel(model);
            PrepareCategoryModelNews(model);
            return View(model);
        }

        #endregion







        public IActionResult List(Models.NewsListModel model)
        {
            PrepareListModel(model);
            PrepareCategoriesModel(model);

            return View(model);
        }













        public IActionResult GetNews(Models.NewsListModel model)
        {

            var _listproducts = _context.News.Include(p => p.Category).Where(p => (p.Title.Contains(model.SearchName) || string.IsNullOrEmpty(model.SearchName)) && (p.CategoryID == model.CategoryId || model.CategoryId == 0)).ToList()
              .Select(p => new { CategoryName = p.Category.CatTitle, p.CategoryID, p.ID, p.Title, p.FullText, p.Imageurl, p.UserId, UserName = p.user.UserName }).ToList();

            return new OkObjectResult(_listproducts);
        }

        [HttpPost]
        public IActionResult SavePicture(int newsid, string picturesid)
        {
            var news = _context.News.Include(p => p.Pictures).SingleOrDefault(p => p.ID == newsid);
            if (news != null)
            {
                news.Pictures.Add(new NewsPicture
                {
                    picturesId = picturesid,


                });
            }
            _context.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public IActionResult GetPictures(int newsid)
        {
            //var _list = Context.News.Include(p => p.Pictures).SingleOrDefault(p => p.ID == newsid).Pictures.Select(p => new { p.ID, p.NewsID, }).ToList();
            var _list = _context.News.FirstOrDefault(p => p.ID == newsid)?.Pictures.Select(p => new { p.ID, p.NewsID, }).ToList();
            return new OkObjectResult(_list);
        }



        [HttpGet]
        public IActionResult Remove(int id)
        {

            var News = _context.News.Find(id);
            _context.Remove(News);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        #region Utilities

        [NonAction]
        private void PrepareListModel(Models.NewsListModel model)
        {
            var _listNews = _context.News.Where(p => (p.Title.Contains(model.NewsSearchName) || string.IsNullOrEmpty(model.NewsSearchName)) && (p.CategoryID == model.CategoryId || model.CategoryId == 0))
                .Select(p => new { CategoryName = p.Category.CatTitle, p.CategoryID, p.ID, p.Title, p.FullText, p.Imageurl, p.UserId, UserFullName = p.user.UserName }).ToList();

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
                    Image = News.Imageurl,
                    FullText = News.FullText,


                });
            }
        }

        [NonAction]
        private void PrepareCategoriesModel(Models.NewsListModel model)
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

        [NonAction]
        private void PrepareCategoryModelNews(NewsModel model)
        {
            var categories = _context.Categories.ToList();
            foreach (var item in categories)
            {
                model.Categories.Add(new SelectListItem()
                {
                    Text = item.CatTitle,
                    Value = item.ID.ToString()
                });
            }
        }

        [NonAction]
        private void PrepareUserModel(NewsModel model)
        {
            var users = _context.Users.Select(p => new { p.LastName, p.Id }).ToList();
            model.Users.Add(new SelectListItem()
            {
                Text = "--",
                Value = "0"
            });
            foreach (var item in users)
            {
                model.Users.Add(new SelectListItem()
                {
                    Text = item.LastName,
                    Value = item.Id.ToString()
                });
            }
        }

        #endregion

    }
}


