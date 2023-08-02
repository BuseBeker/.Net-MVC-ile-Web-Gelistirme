using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class RoleRepository : IRoleDal
    {

        Context context = new Context();
        DbSet<Role> _object; 

        public void Delete(Role p)
        {
            _object.Remove(p);
            context.SaveChanges();
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Role p)
        {
            _object.Add(p);
            context.SaveChanges();
        }

        public List<Role> List()
        {
            return _object.ToList();
        }

        public List<Role> List(Expression<Func<Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Role p)
        {
            context.SaveChanges();
        }
    }
}
