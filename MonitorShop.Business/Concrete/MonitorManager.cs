using MonitorShop.Business.Abstract;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.Business.Concrete
{
    class MonitorManager : IMonitorService
    {
        //Dependancy Injection
        private IMonitorDal _monitor;

        public MonitorManager(IMonitorDal monitor)
        {
            _monitor = monitor;
        }

        public void Add(Monitor entity)
        {
            _monitor.Add(entity);
        }

        public void Delete(Monitor entity)
        {
            _monitor.Delete(entity);
        }

        public Monitor Get(Expression<Func<Monitor, bool>> filter)
        {
            return _monitor.Get(filter);
        }

        public List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null)
        {
            return _monitor.GetAll(filter);
        }

        public void Update(Monitor entity)
        {
            _monitor.Update(entity);
        }
    }
}
