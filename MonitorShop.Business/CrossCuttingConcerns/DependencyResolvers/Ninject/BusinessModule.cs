using MonitorShop.Business.Abstract;
using MonitorShop.Business.Concrete;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.DataAccess.Concrete.AdoNet;
using MonitorShop.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMonitorService>().To<MonitorManager>().InSingletonScope();
            Bind<IMonitorDal>().To<AdoMonitorDal>().InSingletonScope();

            Bind<IPostService>().To<PostManager>().InSingletonScope();
            Bind<IPostDal>().To<AdoPostDal>().InSingletonScope();
        }
    }
}
