using DemoPattern.Core;
using FluentAssertions;

namespace DemoPattern.Pages.Insulia.HCP
{
    class HCPHomePageValidator: BasePageValidator<HCPHomePage, HCPHomePageElementMap, HCPHomePageValidator>
    {
        public HCPHomePage IsPatientGridDisplayed()
        {
            WrapValidators(() =>
            {
                Map.PatientGrid.Displayed.Should().BeTrue();
            }, Map.PatientGrid);
            return PageInstance;
        }

    }
}
