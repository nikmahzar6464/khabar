using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;

namespace Khabar.Controllers
{
    [AllowAnonymous]
    public class CatalogController : Controller
    {
        private readonly IKhabarContext Context = null;

        public CatalogController(IKhabarContext _Context)
        {
            this.Context = _Context;
        }

        [HttpGet("/Category/{categoryName}/")]
        public IActionResult Newscategory(string categoryName)
        {
            //var news = Context.News.Include(p => p.Category).Where(p => p.Category.CatTitle.Contains(categoryName))
            //    .Select(p => new { p.ID, p.Title, p.FullText, p.Imageurl, categoryname = p.Category.CatTitle, p.Pictures.FirstOrDefault().picturesId, p.CategoryID }).ToList();

            var news = Context.News.Include(x => x.Category).Where(x => x.Category.CatTitle.Contains(categoryName)).ToList();
            var model = new Models.NewsCategoryModel
            {
                CategoryName = categoryName,
            };

            foreach (var item in news)
            {
                model.CategoryID = item.CategoryID;
                model.newslist.Add(new Models.NewsItemModel()
                {
                    ID = item.ID,
                    Title = item.Title,
                    FullText = item.FullText,
                    ImageUrl = item.Imageurl
                });
            }

            return View(model);
        }

        //[HttpGet("/Catalog/{NewsName}/")]
        //public IActionResult NewsDetial(string NewsName)
        //{
        //    var Newsesss = Context.News.Include(p => p.Category).Include(p => p.Pictures).Where(p => p.Title.Contains(NewsName)).
        //        Select(p => new { p.ID, p.Pictures.FirstOrDefault().picturesId, p.Title, p.FullText, p.Pictures, Userlastname=p.user.LastName, p.UserId, p.CategoryID, CategoryName = p.Category.CatTitle }).FirstOrDefault();

        //    var model = new Models.NewsDetialModel()
        //    {
        //        ID = Newsesss.ID,
        //        ImageUrl = $"/Pictures/{Newsesss.picturesId}.jpg",
        //        Title = Newsesss.Title,
        //        FullText = Newsesss.FullText,
        //        UserLastName = Newsesss.Userlastname,
        //        CategoryName = Newsesss.CategoryName,


        //    };
        //    foreach (var pictureurl in Newsesss.Pictures)
        //    {
        //        model.ImageUrls.Add($"/Pictures/{pictureurl.picturesId}.jpg");
        //    }
        //    var listid = Newsesss.Title.ToList();
        //    if (listid != null && listid.Count != 0)
        //    {
        //        var _list = Context.News.Include(p => p.Category).Where(p => !p.Title.Contains(NewsName)).Select(p => new { p.ID, p.Title, p.user, p.UserId, p.Imageurl, p.FullText, p.CategoryID }).ToList();
        //        foreach (var item in _list)
        //        {
        //            //model.UserLastName.Add(new Models.NewsItemModel()
        //            //{
        //            //    ID = item.ID,
        //            //    Title = item.Title,
        //            //    FullText = item.FullText,
        //            //      //= item.Imageurl,
        //            //    //PublishDate = item.PublishDate,
        //            //    //Published = item.Published,
        //            //    ImageUrl = $"/Pictures/{item.Imageurl}.jpg",

        //            //});
        //        }
        //    }
        //    return View(model);
        //}

        [HttpGet("/NewsDetails/{newsId}/")]
        public IActionResult NewsDetails(string newsId)
        {
            var model = new Models.NewsDetialModel();
            var news = Context.News.Include(x => x.user).Include(x => x.Category).FirstOrDefault(x => x.ID == int.Parse(newsId));
            if (news != null)
            {
                model.ID = news.ID;
                model.ImageUrl = news.Imageurl;
                model.Title = news.Title;
                model.FullText = news.FullText;
                model.UserLastName = news.user.LastName;
                model.CategoryName = news.Category.CatTitle;

                //Get News Comments
                var comments = Context.Comments.Include(x => x.Customer).Where(x => x.NewsID == int.Parse(newsId)).ToList();
                if (comments.Count > 0)
                {
                    foreach (var comment in comments)
                    {
                        var temp = new CommentListForNews
                        {
                            CommentName = comment.CommentName,
                            CustomerName = comment.Customer.FirstName + " " + comment.Customer.LastName
                        };
                        model.Comments.Add(temp);
                    }
                }
            }
            
            return View("NewsDetails", model);
        }

    }
}
