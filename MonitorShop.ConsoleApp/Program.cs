using MonitorShop.Business.Abstract;
using MonitorShop.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.DataAccess.Concrete.AdoNet;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
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
            monitorService.GetAll().OrderBy(o => o.Id).ToList().ForEach(p => Console.WriteLine(p));

            var postService = InstanceFactory.Get<IPostService>();
            //postService.Add(new Post { Title = "Positive", Details = "Postive Comment" });
            //postService.Add(new Post { Title = "Negatif", Details = "Negatif Comment" });

            postService.GetAll().ForEach(o => Console.WriteLine(o));
            //postService.Delete(new Post { Id = 3 });
            //postService.Delete(new Post { Id = 4 });


            //EF 
            //Console.WriteLine(monitorService.Get(o => o.MonitiorId == 2));

            //Ado And Both
            //GetById
            //monitorService.GetAll().Where(o => o.Id == 3).ToList().ForEach(o => Console.WriteLine(o));
            //Add
            //monitorService.Add(new Monitor{Model="Meta",Stock=3,UnitPrice=300});
            //Add 2
            //monitorService.Add(new Monitor("Meta", 3, 300));
            //Delete
            //monitorService.Delete(new Monitor { Id = 3002 });
            //Update
            //monitorService.Update(new Monitor { Id = 3002, Model = "Meta", Stock = 20, UnitPrice = 400 });
            //GetAll
            //monitorService.GetAll().ForEach(b => Console.WriteLine(b));

            //List<Monitor> monitorList = new List<Monitor>();
            //{
            //    monitorService.Add(new Monitor { Id = 8, Model = "Sony", Stock = 5, UnitPrice = 500, });
            //    monitorService.Add(new Monitor { Id = 9, Model = "Sony", Stock = 5, UnitPrice = 500, });
            //    monitorService.Add(new Monitor { Id = 10, Model = "Sony", Stock = 5, UnitPrice = 500, });
            //    monitorService.Add(new Monitor { Id = 11, Model = "Sony", Stock = 5, UnitPrice = 500, });
            //    monitorService.Add(new Monitor { Id = 12, Model = "Sony", Stock = 5, UnitPrice = 500, });
            //}
            //foreach (var item in monitorList)
            //{
            //    Console.WriteLine(item.Model);
            //}
            //monitorService.Delete(new Monitor { Id = 4006 });
            //monitorService.Update(new Monitor { Id = 4002, Model = "Vestel", Stock = 10, UnitPrice = 750 });


            Console.ReadKey();
        }
    }
}
