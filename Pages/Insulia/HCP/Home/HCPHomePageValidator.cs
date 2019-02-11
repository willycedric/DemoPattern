using FluentPageObjectPattern.Core;
using FluentAssertions;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class HCPHomePageValidator: BasePageValidator<HCPHomePage, HCPHomePageElementMap, HCPHomePageValidator>
    {
        public HCPHomePage IsPatientGridDisplayed()
        {
            WrapValidators(() =>
            {
                Map.PatientGrid.Displayed.Should().Be(true);
            }, Map.PatientGrid);
            return PageInstance;
        }

    }
}
