using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserRoleService
    {
        List<UserRole> GetList();
        //int SelectedFieldId { get; set; }
        void UserRoleAdd(UserRole userRole);
        UserRole GetByID(int id);
        void UserRoleDelete(UserRole userRole);
        void UserRoleUpdate(UserRole userRole);

        //List<UserRole> GetListByID(int id);
    }
}
