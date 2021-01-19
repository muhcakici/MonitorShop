using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.DataAccess.Abstract
{
    public interface IMonitorDal : IEntityRepository<Monitor>
    {
    }
}
