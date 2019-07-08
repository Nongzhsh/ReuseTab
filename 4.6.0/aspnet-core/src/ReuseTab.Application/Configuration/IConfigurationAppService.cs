using System.Threading.Tasks;
using ReuseTab.Configuration.Dto;

namespace ReuseTab.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
