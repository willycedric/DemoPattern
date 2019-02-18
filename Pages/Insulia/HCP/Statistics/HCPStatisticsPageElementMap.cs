using DemoPattern.Core;
using OpenQA.Selenium;

namespace DemoPattern.Pages.Insulia.HCP
{
    class HCPStatisticsPageElementMap:BasePageElementMap
    {
        public IWebElement StatisticPageTitle
        {
            get
            {
                return Browser.FindElement(By.Id("cphMain_cphWebParts_Stats_lblA1CTitleDistribution"));
            }
        }

        public IWebElement HCPStatisticsMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[2]/a/span")));
            }
        }

    }
}
