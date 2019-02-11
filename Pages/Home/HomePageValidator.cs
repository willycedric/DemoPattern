using FluentAssertions;
using NUnit.Framework;
using FluentPageObjectPattern.Core;

namespace FluentPageObjectPattern.Pages.Demo.Home
{
    class HomePageValidator: BasePageValidator<DemoHomePage, HomePageElementMap, HomePageValidator>
    {
        public DemoHomePage CheckHomeHeader(string expectedHeader)
        {
            Map.HomePageDescription.Text.ToLower().Should().Be(expectedHeader.ToLower());
            return PageInstance;
        }
    }
}
