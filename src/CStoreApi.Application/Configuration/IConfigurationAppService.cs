using System.Threading.Tasks;
using CStoreApi.Configuration.Dto;

namespace CStoreApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
