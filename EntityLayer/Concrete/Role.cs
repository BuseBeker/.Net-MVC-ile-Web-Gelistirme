using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Role()
        //{
        //    this.UserRoles = new HashSet<UserRole>();
        //}

        [Key]
        public int RoleID { get; set; }

        [StringLength(500)]
        public string RoleName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        //public bool RoleStatus { get; set; }

        //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<UserRole> UserRoles { get; set; } // public virtual ICollection<UserRole> UserRoles
    }
}



