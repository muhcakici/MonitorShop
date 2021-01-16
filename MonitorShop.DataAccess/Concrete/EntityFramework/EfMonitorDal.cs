using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.EntityFramework
{
    public class EfMonitorDal:EfRepositoryBase<Monitor,MonitorShopContext>,IMonitorDal
    {

    }
}
