using Microsoft.AspNetCore.Mvc;
using DataLayer;
using Domains;
using Microsoft.AspNetCore.Authorization;
using Models;

namespace Controllers
{
    [AllowAnonymous]
    public class CommentsController : Controller
    {
        private SqlServerKhabarContext _context;

        public CommentsController(SqlServerKhabarContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return Redirect("/Home/index");
        }


        [HttpPost]
        public IActionResult Create([Bind("ID, CustomerId,CommentName")] NewsDetialModel model)
        {
            Comment comment = new Comment()
            {
                CommentName = model.CommentName,
                CustomerID = int.Parse(model.CustomerId),
                NewsID = model.ID
            };
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
