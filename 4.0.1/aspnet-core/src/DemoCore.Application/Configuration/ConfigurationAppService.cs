using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DemoCore.Configuration.Dto;

namespace DemoCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
