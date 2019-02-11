using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;

namespace FluentPageObjectPattern.Pages.Insulia
{
    class HomePage:BaseFluentPageSingleton<HomePage, HomePageElementMap, HomePageValidator>
    {
        
        public new HomePage GoToUrl(string url = "https://verification2012.medpassport.net/REDWING_1.6.50_US")
        {

            WrapStepAction(() =>
            {
                base.GoToUrl(url);
            });
            return this as HomePage;
        }

        public HomePage EnterUserLogin(string userLogin)
        {
            WrapStepAction(() =>
            {
                Map.LoginField.Clear();
                Map.LoginField.SendKeys(userLogin);
            });
            return this as HomePage;
        }

        public HomePage EnterUserPassword(string userPassword)
        {
            WrapStepAction(() =>
            {
                Map.PasswordField.Clear();
                Map.PasswordField.SendKeys(userPassword);
            });
            return this as HomePage;
        }

        public HomePage Login()
        {
            WrapStepAction(() =>
            {
                Map.LoginButton.Click();
            });
            return this as HomePage;
        }
    }
}
