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
        private readonly IKhabarContext Context = null;

        public CommentController(IKhabarContext _Context)
        {
            this.Context = _Context;
        }
        public IActionResult Index()
        {
            return Redirect("/Admin/Comment/List");
        }



        #region Utilities
        [NonAction]
        private void PrepareListModel(Models.CommentListModel model)
        {
            var _listcomment = Context.Comments.Where(p => (p.CommentName.Contains(model.CommentSearchName) || string.IsNullOrEmpty(model.CommentSearchName)) )
                .Select(p => new {p.NewsID, NewsTitle = p.newses.Title, p.ID, p.CommentName,  p.CustomerID, }).ToList();

            foreach (var Comment in _listcomment)
            {
                model.Comments.Add(new Models.CommentListModel.CommentListItem
                {
                    NewsID = Comment.NewsID,
                    NewsTitle= Comment.NewsTitle,
                    UserID = Comment.CustomerID,
                    //UserFullName = Comment.UserFullName,

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


        [HttpGet]
        public IActionResult Remove(int id)
        {

            var Comments = Context.Comments.Find(id);
            Context.Remove(Comments);
            Context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
