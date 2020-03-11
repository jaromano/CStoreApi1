using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CStoreApi.Roles.Dto;
using CStoreApi.Users.Dto;

namespace CStoreApi.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
