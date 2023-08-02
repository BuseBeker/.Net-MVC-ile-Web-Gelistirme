using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }

        public UserRole GetByID(int id)
        {
            return _userRoleDal.Get(x => x.UserRoleID == id);
           
         }
        public List<UserRole> GetList()
        {
            return _userRoleDal.List();
        }

        public void UserRoleAdd(UserRole userRole)
        {
            _userRoleDal.Insert(userRole);
        }

        public void UserRoleDelete(UserRole userRole)
        {
            _userRoleDal.Delete(userRole);
        }

        public void UserRoleUpdate(UserRole userRole)
        {
            _userRoleDal.Update(userRole);
        }
    }
}
