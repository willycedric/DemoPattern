using FluentPageObjectPattern.Core;
using OpenQA.Selenium;
using NUnit.Framework;
using FluentAssertions;
using FluentPageObjectPattern.StepHelpers;
using System;
using FluentPageObjectPattern.Pages.Insulia.Interface;
namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class Preferences_PageValidator:BasePageValidator<Preferences_Page, Preferences_PageElementMap, Preferences_PageValidator>, ISubSectionValidator
    {
        public void IsEditedInfomationsMatch(SettingsPageElementMap Map , EditSectionFields hcpInformations, Func<IWebElement, string, bool> performCheck)
        {
            WrapValidators(() =>
            {
                Assert.Multiple(() =>
                {
                    performCheck(Map.HCPInformationByText(hcpInformations.HeighUnit), hcpInformations.HeighUnit).Should().Be(true, $"HCP Height Unit  {hcpInformations.HeighUnit} does not match ");
                    performCheck(Map.HCPInformationByText(hcpInformations.WeightUnit), hcpInformations.WeightUnit).Should().Be(true, $"HCP Weight Unit  {hcpInformations.WeightUnit} does not match ");
                    performCheck(Map.HCPInformationByText(hcpInformations.Language), hcpInformations.Language).Should().Be(true, $"HCP Language {hcpInformations.Language} does not match");
                });
            }, Map.HCPEditPreferenceButton);

        }
    }
}
