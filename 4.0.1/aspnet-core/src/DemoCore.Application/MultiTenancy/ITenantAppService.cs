using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DemoCore.MultiTenancy.Dto;

namespace DemoCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
