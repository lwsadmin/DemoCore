using System.Threading.Tasks;
using Abp.Application.Services;
using DemoCore.Sessions.Dto;

namespace DemoCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
