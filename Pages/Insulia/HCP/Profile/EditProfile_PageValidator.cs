using DemoPattern.Core;
using OpenQA.Selenium;
using NUnit.Framework;
using FluentAssertions;
using DemoPattern.StepHelpers;
using System;
using DemoPattern.Pages.Insulia.Interface;

namespace DemoPattern.Pages.Insulia.HCP
{
    class EditProfile_PageValidator : BasePageValidator<EditProfile_Page , EditProfile_PageElementMap, EditProfile_PageValidator>, ISubSectionValidator
    {

        public void IsEditedInfomationsMatch(SettingsPageElementMap Map, EditSectionFields hcpInformations, Func<IWebElement, string, bool> performCheck)
        {
            WrapValidators(() =>
            {
                Assert.Multiple(() =>
                {
                    performCheck(Map.HCPFirstName(hcpInformations.FirstName), hcpInformations.FirstName).Should().Be(true, $"HCP FirstName {hcpInformations.FirstName} does not match ");
                    performCheck(Map.HCPLastName(hcpInformations.LastName), hcpInformations.LastName).Should().Be(true, $"HCP LastName {hcpInformations.LastName} does not match ");
                    performCheck(Map.HCPInformationByText(hcpInformations.Email), hcpInformations.Email).Should().Be(true, $"HCP Email {hcpInformations.Email} does not match");
                    performCheck(Map.HCPInformationByText(hcpInformations.ConfirmationEmail), hcpInformations.ConfirmationEmail).Should().Be(true, $"HCP Confirmation Email {hcpInformations.ConfirmationEmail} does  not match");
                });
            }, Map.HCPEditProfileButton);



        }
    }
}
