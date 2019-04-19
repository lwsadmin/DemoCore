using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoCore.Configuration;

namespace DemoCore.Web.Startup
{
    //[DependsOn(typeof(AbpWebSignalRModule))]
    [DependsOn(typeof(DemoCoreWebCoreModule))]
    public class DemoCoreWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoCoreWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<DemoCoreNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoCoreWebMvcModule).GetAssembly());
        }
    }
}
