using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.Interface;
namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class HCPStatisticsPage:BaseFluentPageSingleton<HCPStatisticsPage, HCPStatisticsPageElementMap, HCPStatisticsPageValidator>, IHCPSubPage
    {
        public void Navigate()
        {
            Map.HCPStatisticsMenu.Click();
        }
    }
}
