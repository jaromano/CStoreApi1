using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CStoreApi.Authorization;

namespace CStoreApi
{
    [DependsOn(
        typeof(CStoreApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CStoreApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CStoreApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CStoreApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
