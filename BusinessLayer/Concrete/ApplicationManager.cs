using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public Application GetByID(int id)
        {
            return _applicationDal.Get(x => x.ApplicationID == id);
        }

        public List<Application> GetList()
        {
            return _applicationDal.List();
        }

        public void ApplicationAdd(Application application)
        {
            _applicationDal.Insert(application);


        }

        public void ApplicationDelete(Application application)
        {
            _applicationDal.Update(application);
            //_applicationDal.Delete(application);
        }

        public void ApplicationUpdate(Application application)
        {
            _applicationDal.Update(application);
        }

        public List<Application> GetListByUser(int id)
        {
            return _applicationDal.List(temp => temp.UserID == id);
        }
    }
}
