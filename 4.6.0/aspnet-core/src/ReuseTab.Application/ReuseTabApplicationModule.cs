using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReuseTab.Authorization;

namespace ReuseTab
{
    [DependsOn(
        typeof(ReuseTabCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReuseTabApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReuseTabAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReuseTabApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
