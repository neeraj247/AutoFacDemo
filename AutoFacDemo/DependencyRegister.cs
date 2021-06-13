using Autofac;
using AutoFacDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacDemo
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutoFacService>().As<IAutoFacService>().InstancePerLifetimeScope();
            
            // We can use this as well
            //builder.RegisterType<AutoFacService>().AsImplementedInterfaces();
        }
    }
}
