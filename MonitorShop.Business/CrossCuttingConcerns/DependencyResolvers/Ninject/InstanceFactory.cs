﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T Get<T>()
        {
            return new StandardKernel(new BusinessModule()).Get<T>();
        }
    }
}
