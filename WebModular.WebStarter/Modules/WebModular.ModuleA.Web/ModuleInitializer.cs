using Microsoft.Extensions.DependencyInjection;
using WebModular.Core;
using WebModular.ModuleA.Common;
using WebModular.ModuleA.Service;

namespace WebModular.ModuleA.Web
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Init(IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
        }
    }
}
