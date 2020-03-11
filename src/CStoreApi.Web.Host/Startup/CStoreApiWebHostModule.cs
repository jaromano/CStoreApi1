using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CStoreApi.Configuration;

namespace CStoreApi.Web.Host.Startup
{
    [DependsOn(
       typeof(CStoreApiWebCoreModule))]
    public class CStoreApiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CStoreApiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CStoreApiWebHostModule).GetAssembly());
        }
    }
}
