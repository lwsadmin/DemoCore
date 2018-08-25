using System.Threading.Tasks;
using DemoCore.Configuration.Dto;

namespace DemoCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
