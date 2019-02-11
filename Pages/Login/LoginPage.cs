using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Demo.Home;

namespace FluentPageObjectPattern.Pages.Login
{
    class LoginPage: BaseFluentPageSingleton<LoginPage, LoginPageElementMap , LoginPageValidator>
    {
        public new LoginPage Navigate(string url = "http://executeautomation.com/demosite/Login.html")
        {
            base.Navigate(url);
            return this as LoginPage;
        }

        public LoginPage EnterUserName(string userName)
        {
            Map.UserNameField.Clear();
            Map.UserNameField.SendKeys(userName);
            return this as LoginPage;
        }

        public LoginPage EnterUserPassword(string userPassword)
        {
            Map.PasswordField.Clear();
            Map.PasswordField.SendKeys(userPassword);
            return this as LoginPage;
        }

        public DemoHomePage Login()
        {
            
            Map.LoginButton.Click();
            return  new DemoHomePage();
        }

    }
}
