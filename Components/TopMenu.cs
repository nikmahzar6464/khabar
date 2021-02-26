using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Khabar.Components
{
    public class TopMenuViewComponent:ViewComponent
    {
        private readonly IKhabarContext Context = null;
        public TopMenuViewComponent(IKhabarContext _Context)
        {
            this.Context = _Context;
        }

        public IViewComponentResult Invoke()
        {
            var _list = Context.Categories.Select(p=>new {p.ID,p.CatTitle }).ToList();

            var model =new Models.TopMenuModel();
            foreach (var item in _list)
            {
                model.ListMenu.Add(new Models.TopMenuItemModel() {
                    ID=item.ID,
                    MenuName=item.CatTitle
                });
            }
            return View(model);
        }
    }
}
