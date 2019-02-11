using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using FluentAssertions;
using NUnit.Framework;

namespace FluentPageObjectPattern.Pages.Login
{
    class LoginPageValidator : BasePageValidator<LoginPage, LoginPageElementMap, LoginPageValidator>
    {

        public LoginPage LoginPageDescription(string expectedDescription)
        {
            Map.LoginPageDescription.Text.Should().Be(expectedDescription);
            return PageInstance;
        }

        public LoginPage CheckThatUserIsSuccessfullyLogout(string expectedDescription)
        {
            Map.LoginPageDescription.Text.Should().Be(expectedDescription);
                return PageInstance;
        }

    }
}
