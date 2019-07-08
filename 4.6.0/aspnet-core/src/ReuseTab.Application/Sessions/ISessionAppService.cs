using System.Threading.Tasks;
using Abp.Application.Services;
using ReuseTab.Sessions.Dto;

namespace ReuseTab.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
