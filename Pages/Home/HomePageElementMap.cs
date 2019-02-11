using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using OpenQA.Selenium;

namespace FluentPageObjectPattern.Pages.Demo.Home
{
    public class HomePageElementMap: BasePageElementMap
    {

        public IWebElement HomePageDescription
        {
            get
            {
                return Browser.FindElement(By.TagName("p"));
            }
        }

        public IWebElement HomepageLogOutLink
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='cssmenu']/ul/li[1]/a/span"));
            }
        }
    }
}
