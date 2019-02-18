using DemoPattern.Core;
using DemoPattern.Pages.Insulia.Interface;
namespace DemoPattern.Pages.Insulia.HCP
{
    class HCPStatisticsPage:BaseFluentPageSingleton<HCPStatisticsPage, HCPStatisticsPageElementMap, HCPStatisticsPageValidator>, IHCPSubPage
    {
        public void Navigate()
        {
            Map.HCPStatisticsMenu.Click();
        }
    }
}
