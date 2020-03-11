using System.Threading.Tasks;
using Abp.Application.Services;
using CStoreApi.Sessions.Dto;

namespace CStoreApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
