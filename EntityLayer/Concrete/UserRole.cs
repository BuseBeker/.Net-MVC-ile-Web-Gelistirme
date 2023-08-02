using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }

        //[Key, Column(Order = 1)]
        
        public int UserID { get; set; }

        //[Key, Column(Order = 2)]
       
        public int RoleID { get; set; }

        [StringLength(500)]
        public string Assigner { get; set; }

        //public bool UserRoleStatus { get; set; }

        //public DateTime RecordDate { get; set; }
        
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }

    //public class UserViewModel
    //{
    //    public List<Role> RoleList { get; set; }
    //    public int SelectedRoleId { get; set; }
    //}

}
