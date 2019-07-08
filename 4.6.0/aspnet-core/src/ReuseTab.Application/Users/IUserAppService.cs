using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReuseTab.Roles.Dto;
using ReuseTab.Users.Dto;

namespace ReuseTab.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
