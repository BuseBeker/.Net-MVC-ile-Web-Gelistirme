using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels
{
    public class RoleViewModel
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }
    }
}
