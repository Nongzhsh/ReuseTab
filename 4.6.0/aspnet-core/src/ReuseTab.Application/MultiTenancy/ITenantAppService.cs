using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReuseTab.MultiTenancy.Dto;

namespace ReuseTab.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

