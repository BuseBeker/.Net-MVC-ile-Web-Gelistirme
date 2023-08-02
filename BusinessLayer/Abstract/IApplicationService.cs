using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IApplicationService
    {
        List<Application> GetList();
        List<Application> GetListByUser(int id);
        void ApplicationAdd(Application application);
        Application GetByID(int id);
        void ApplicationDelete(Application application);
        void ApplicationUpdate(Application application);

        //void ApplicationDetail(Application application);
    }
}
