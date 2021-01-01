using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using DataLayer;

namespace Khabar.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        KhabarContext Context = new KhabarContext();
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }



        #region Utilities
        [NonAction]
        private void PrepareListModel(Models.CommentListModel model)
        {
            var _listcomment = Context.Comments.Where(p => (p.CommentName.Contains(model.CommentSearchName) || string.IsNullOrEmpty(model.CommentSearchName)) )
                .Select(p => new {p.NewsID, NewsTitle = p.newses.Title, p.ID, p.CommentName, UserFullName = p.User.FullName, p.UserID, }).ToList();

            foreach (var Comment in _listcomment)
            {
                model.Comments.Add(new Models.CommentListModel.CommentListItem
                {
                    NewsID = Comment.NewsID,
                    NewsTitle= Comment.NewsTitle,
                    UserID = Comment.UserID,
                    UserFullName = Comment.UserFullName,

                    ID = Comment.ID,
                    CommentName = Comment.CommentName,



                });
            }
        }
        
        #endregion

        [HttpGet]
        public IActionResult List(Models.CommentListModel model)
        {


            PrepareListModel(model);

            return View(model);
        }
    }
}
