using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.AdoNet
{
    public class AdoMonitorDal : IMonitorDal
    {
        public void Add(Monitor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Monitor entity)
        {
            throw new NotImplementedException();
        }

        public Monitor Get(Expression<Func<Monitor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null)
        {
            List<Monitor> monitors = new List<Monitor>
            {
                new Monitor{MonitiorId=1,Model="AdoHp",Stock=16,UnitPrice=3500},
                new Monitor{MonitiorId=2,Model="AdoApple",Stock=20,UnitPrice=3500},
                new Monitor{MonitiorId=3,Model="AdoVestel",Stock=14,UnitPrice=3500},
                new Monitor{MonitiorId=4,Model="AdoLG",Stock=18,UnitPrice=3500},
                new Monitor{MonitiorId=5,Model="AdoSamsung",Stock=10,UnitPrice=3500}

            };
            return monitors;
        }

        public void Update(Monitor entity)
        {
            throw new NotImplementedException();
        }
    }
}
