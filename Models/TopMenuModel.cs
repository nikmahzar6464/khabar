using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{

    public class TopMenuModel
    {
        public TopMenuModel()
        {
            this.ListMenu = new List<TopMenuItemModel>();
        }

        public List<TopMenuItemModel> ListMenu { get; set; }
    }
    public class TopMenuItemModel
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public int ParentId { get; set; }
    }
}
