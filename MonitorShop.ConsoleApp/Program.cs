using MonitorShop.Business.Abstract;
using MonitorShop.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using System;

namespace MonitorShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitorService = InstanceFactory.Get<IMonitorService>();
            var list = monitorService.GetAll();
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
