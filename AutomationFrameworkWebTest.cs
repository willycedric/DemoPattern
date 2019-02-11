using NUnit.Framework;
using QAVoluntisAutomationFrameworkWeb.WebDriverFactory;
using OpenQA.Selenium;
using FluentAssertions;

namespace QAVoluntisAutomationFrameworkWeb.Test
{

    [TestFixture]
    class AutomationFrameworkWebTest
    {


        [TestFixture]
        public class StaticWebDriverFactoryTests
        {
            private IWebDriver LocalDriver { get; set; }            
            [Test]         
            public void LocalWebDriverCanBeLaunchedAndLoadExampleDotCom()
            {
                LocalDriver = StaticWebDriverFactory.GetLocalWebDriver((int)Browser.Firefox);
                LocalDriver.Url = "https://example.com/";
                LocalDriver.Title.Should().Be("Example Domain");
            }

        }
    }
}
