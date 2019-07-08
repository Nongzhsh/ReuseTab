using System.Threading.Tasks;
using Abp.Application.Services;
using ReuseTab.Authorization.Accounts.Dto;

namespace ReuseTab.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
