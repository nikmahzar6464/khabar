using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Khabar.Controllers
{
    [Area("Admin")]
    public class UserLimitedController : Controller
    {
        KhabarContext context = new KhabarContext();


        #region Utilities
        [NonAction]
        private void PrepareListModel(Models.UserListModel model)
        {
            var _listuser = context.Users.Where(p => (p.FullName.Contains(model.UserSearchName) || string.IsNullOrEmpty(model.UserSearchName)) && (p.UserTypeID==3 ))
                .Select(p => new { userTypeName = p.UserType.UserTypeName, p.UserTypeID, p.ID, p.Email, p.FullName, p.Mobile, p.NationalCode, p.PassWord, p.UserName, }).ToList();

            foreach (var Users in _listuser)
            {
                model.Users.Add(new Models.UserListModel.UserListItem
                {
                    UserName = Users.UserName,
                    NationalCode = Users.NationalCode,
                    ID = Users.ID,
                    Email = Users.Email,
                    FullName = Users.FullName,
                    Mobile = Users.Mobile,
                    PassWord = Users.PassWord,
                    UserTypeName = Users.userTypeName,
                    UserTypeID = Users.UserTypeID,


                });
            }
        }
        #endregion
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }


        public IActionResult List(UserListModel model)
        {
            PrepareListModel(model);
            return View(model);
        }



        [HttpGet]
        public IActionResult Create(int? id)
        {
            var model = new Models.UserModel();
            if (id.HasValue)
            {
                var Users = context.Users.Find(id);
                model.UserName = Users.UserName;
                model.ID = Users.ID;
                model.FullName = Users.FullName;
                model.Email = Users.Email;
                model.Mobile = Users.Mobile;
                model.PassWord = Users.PassWord;
                model.UserTypeID = Users.UserTypeID;
                model.NationalCode = Users.NationalCode;

            }
            PrepareUsersModelUserTypes(model);
            return View(model);
        }



        [HttpPost]
        public IActionResult Create(UserModel model)
        {

            if (ModelState.IsValid && ModelState.ErrorCount == 0)
            {
                Domains.User user = new Domains.User();
                user.ID = model.ID;
                user.FullName = model.FullName;
                user.Email = model.Email;
                user.UserTypeID = model.UserTypeID;
                user.UserName = model.UserName;
                user.PassWord = model.PassWord;
                user.Mobile = model.Mobile;
                user.ID = model.ID;
                user.NationalCode = model.NationalCode;
                context.Update(user);
                context.SaveChanges();
                return RedirectToAction("List");
            }

            PrepareUsersModelUserTypes(model);
            return View(model);
        }

        [NonAction]
        private void PrepareUsersModelUserTypes(UserModel model)
        {
            var UserTypes = context.UserTypes.ToList();

            model.UserTypes.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
            {
                Text = "...",
                Value = "0"
            });
            foreach (var item in UserTypes)
            {
                model.UserTypes.Add(new SelectListItem()
                {
                    Text = item.UserTypeName,
                    Value = item.ID.ToString()
                });
            }
        }
    }
}
