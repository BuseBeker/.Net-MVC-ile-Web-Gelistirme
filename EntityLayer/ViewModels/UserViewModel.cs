using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels
{

    public class UserViewModel
    {
        public List<Role> RoleList { get; set; }
        public int SelectedRoleId { get; set; }
    }

}
