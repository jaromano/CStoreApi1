using Abp.Application.Services;
using CStoreApi.MultiTenancy.Dto;

namespace CStoreApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

