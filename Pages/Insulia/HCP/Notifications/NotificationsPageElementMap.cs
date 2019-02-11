using FluentPageObjectPattern.Core;
using OpenQA.Selenium;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class NotificationsPageElementMap:BasePageElementMap
    {
        public IWebElement NotificationPageTitle
        {
            get
            {
               return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("analysisMessageTitle")));
                
            }
        }
        public IWebElement HCPNotificationMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[3]/a/span[1]")));
            }
        }
    }
}
