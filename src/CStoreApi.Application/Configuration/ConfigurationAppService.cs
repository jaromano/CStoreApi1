using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CStoreApi.Configuration.Dto;

namespace CStoreApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CStoreApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
