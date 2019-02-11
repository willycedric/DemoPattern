using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Login;

namespace FluentPageObjectPattern.Pages.Demo.Home
{
    class DemoHomePage: BaseFluentPageSingleton<DemoHomePage, HomePageElementMap, HomePageValidator>
    {
        public LoginPage Logout()
        {
            Map.HomepageLogOutLink.Click();
            return new LoginPage();
        }
    }
}
