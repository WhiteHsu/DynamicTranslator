﻿using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;

using DynamicTranslator.Dependency.Markers;

namespace DynamicTranslator.Dependency
{
    public class BasicConventionalRegistrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            //Transient
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                       .IncludeNonPublicTypes()
                       .BasedOn<ITransientDependency>()
                       .WithService.Self()
                       .WithService.DefaultInterfaces()
                       .LifestyleTransient()
                       .WithServiceAllInterfaces()
                );

            //Singleton
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                       .IncludeNonPublicTypes()
                       .BasedOn<ISingletonDependency>()
                       .WithService.Self()
                       .WithService.DefaultInterfaces()
                       .LifestyleSingleton()
                       .WithServiceAllInterfaces()
                );

            //Windsor Interceptors
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                       .IncludeNonPublicTypes()
                       .BasedOn<IInterceptor>()
                       .WithService.Self()
                       .LifestyleTransient()
                );
        }
    }
}