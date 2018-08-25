using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoCore.Authorization;

namespace DemoCore
{
    [DependsOn(
        typeof(DemoCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
