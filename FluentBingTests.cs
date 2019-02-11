// <copyright file="FluentBingTests.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using FluentPageObjectPattern.Enums;
using NUnit.Framework;

namespace FluentPageObjectPattern
{
    [TestFixture]
    public class FluentBingTests
    { 
        [SetUp]
        public void SetupTest()
        {
            Core.Driver.StartBrowser();
        }

        [TearDown]
        public void TeardownTest()
        {
            Core.Driver.StopBrowser();
        }

        [TestCase("Login")]
        public void UserShouldbeAbleToReachTheLoginPage(string expectedDescription) => Pages.
                Login
                .LoginPage
                .Instance
                    .Navigate()
                 .Validate()
                    .LoginPageDescription(expectedDescription: expectedDescription);

        [TestCase("username", "password", "This is a demo website, which act as a mock site for trying out different automation tools")]
        public void UserShouldBeAbleToLoginWithValideCredentials(string userName, string userPassword, string homeHeader)=> Pages.
                Login
                .LoginPage
                .Instance
                    .Navigate()
                    .EnterUserName(userName:userName)
                    .EnterUserPassword(userPassword: userPassword)
                    .Login()
                 .Validate()
                    .CheckHomeHeader(expectedHeader: homeHeader);
        

        [TestCase("username", "password", "Login")]
        public void UserShouldBeAbleToLogout(string userName, string userPassword, string loginDescription) => Pages.
                Login
                .LoginPage
                .Instance
                    .Navigate()
                    .EnterUserName(userName: userName)
                    .EnterUserPassword(userPassword: userPassword)
                    .Login()
                    .Logout()
                 .Validate()
                    .CheckThatUserIsSuccessfullyLogout(expectedDescription: loginDescription);

    }
}