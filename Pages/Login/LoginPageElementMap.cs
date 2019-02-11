using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using OpenQA.Selenium;

namespace FluentPageObjectPattern.Pages.Login
{
    public class LoginPageElementMap:BasePageElementMap
    {

        public IWebElement UserNameField
        {
            get
            {
                return Browser.FindElement(By.Name("UserName"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return Browser.FindElement(By.Name("Password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='userName']/p[3]/input"));
            }
        }

        public IWebElement LoginPageDescription
        {
            get
            {
                return Browser.FindElement(By.TagName("h2"));
            }
        }
    }
}
