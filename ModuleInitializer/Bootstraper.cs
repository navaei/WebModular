using System;
using Microsoft.Extensions.DependencyInjection;
using WebModular.Core;

namespace WebModular.ModuleInitializer
{
    public static class Bootstrapper
    {
        public static void Start(IServiceCollection services)
        {
            var dummy = typeof(ModuleA.Web.ModuleInitializer);
            //services.AddTransient<ITestService, TestService>();
            services.AddModule(new ModuleA.Web.ModuleInitializer());
        }

        static void AddModule(this IServiceCollection services, IModuleInitializer moduleInitializer)
        {
            moduleInitializer.Init(services);
        }
    }
}
