using System.Threading.Tasks;
using Abp.Application.Services;
using CStoreApi.Authorization.Accounts.Dto;

namespace CStoreApi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
