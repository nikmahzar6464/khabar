using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class ManageCustomeRoleModel
    {
        public ManageCustomeRoleModel()
        {
            ListRoles = new List<CustomerRole>();
            AssignedRoles = new List<CustomerRole>();
        }
        public string fullName { get; set; }
        public  string Id { get; set; }
        public List<CustomerRole> ListRoles { get; set; }
        public List<CustomerRole> AssignedRoles { get; set; }
    }
}
