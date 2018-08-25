using System.Threading.Tasks;
using Abp.Application.Services;
using DemoCore.Authorization.Accounts.Dto;

namespace DemoCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
