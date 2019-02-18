using DemoPattern.Core;
using FluentAssertions;

namespace DemoPattern.Pages.Insulia.HCP
{
    class HCPStatisticsPageValidator: BasePageValidator<HCPStatisticsPage, HCPStatisticsPageElementMap, HCPStatisticsPageValidator>
    {
        public HCPStatisticsPage IsStatisticPageDisplayed()
        {
            WrapValidators(() =>
            {
                Map.StatisticPageTitle.Displayed.Should().Be(true);
            });
            return PageInstance;
        }
    }
}
