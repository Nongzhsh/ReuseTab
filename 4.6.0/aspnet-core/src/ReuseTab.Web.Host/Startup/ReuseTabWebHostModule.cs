using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReuseTab.Configuration;

namespace ReuseTab.Web.Host.Startup
{
    [DependsOn(
       typeof(ReuseTabWebCoreModule))]
    public class ReuseTabWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReuseTabWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReuseTabWebHostModule).GetAssembly());
        }
    }
}
