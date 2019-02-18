using DemoPattern.Core;
using OpenQA.Selenium;

namespace DemoPattern.Pages.Insulia.HCP
{
    class HCPHomePageElementMap: BasePageElementMap
    {
        public IWebElement PatientGrid
        {
            get
            {
                return BrowserWait.Until((Browser)=> Browser.FindElement(By.Id("gridPatients")));
            }
        }

        public IWebElement HCPStatisticsMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[2]/a/span")));
            }
        }

       public IWebElement HCPNotificationMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[3]/a/span[1]")));
            }
        }

        public IWebElement HCPSettingsMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[4]/a/span")));
            }
        }
    }
}
