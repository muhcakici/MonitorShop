using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.Business.Abstract
{
    public interface IMonitorService
    {
        List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null);
        Monitor Get(Expression<Func<Monitor, bool>> filter);
        void Add(Monitor entity);
        void Update(Monitor entity);
        void Delete(Monitor entity);
    }
}
