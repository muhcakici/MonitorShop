using MonitorShop.Business.Abstract;
using MonitorShop.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.DataAccess.Concrete.AdoNet;
using MonitorShop.Entities.Concrete;
using System;
using System.Linq;

namespace MonitorShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new AdoMonitorDal().GetAll().ToList().ForEach(b => Console.WriteLine(b));
            //var monitor = new AdoMonitorDal().Get(1);
            //Console.WriteLine(monitor);

            var monitorService = InstanceFactory.Get<IMonitorService>();
            monitorService.GetAll().ForEach(b => Console.WriteLine(b));
            //EF Aktif Olursa
            //Console.WriteLine(monitorService.Get(o => o.MonitiorId == 2));
            
            //Ado 
            //GetById
            monitorService.GetAll().Where(o => o.Id == 3).ToList().ForEach(o => Console.WriteLine(o));
            //Add
            //monitorService.Add(new Monitor{Model="Meta",Stock=3,UnitPrice=300});
            //Delete
            //monitorService.Delete(new Monitor { Id = 1002 });

             


            Console.ReadKey();
        }
    }
}
