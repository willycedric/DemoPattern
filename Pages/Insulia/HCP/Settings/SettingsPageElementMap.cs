using FluentPageObjectPattern.Core;
using OpenQA.Selenium;
using FluentPageObjectPattern.Pages.Insulia.Interface;
namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class SettingsPageElementMap:BasePageElementMap
    {
        public IWebElement SectionProfileTitle
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.ClassName("rwSectionHeaderTitle")));
            }
        }

        public IWebElement HCPSettingsMenu
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[4]/a/span")));
            }
        }

        public IWebElement HCPEditProfileButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_btnEdit")));
            }
        }

        public IWebElement HCPEditPreferenceButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfileLanguagesUnit_btnEdit")));
            }
        }

        public IWebElement HCPUpdatePasswordButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_btnChangePassword")));
            }
        }

        public IWebElement HCPFirstName(string HcpFirstName)
        {
            var insuliaSpecificFirstName = char.ToUpper(HcpFirstName[0]) + HcpFirstName.Substring(1).ToLower();
            var t= BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//tbody/tr/td[contains(text(),'{insuliaSpecificFirstName}')]")));
            return t;
            
        }

        public IWebElement HCPLastName(string HcpLastName)
        {

            return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//tbody/tr/td[contains(text(),'{HcpLastName.ToUpper()}')]")));

        }

        public IWebElement HCPInformationByText(string hcpTargetedInfo)
        {

            return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//tbody/tr/td[contains(text(),'{hcpTargetedInfo}')]")));

        }
        public IWebElement HCPConfirmationEmail(string HcpConfirmationEmail)
        {

            return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//tbody/tr/td[contains(text(),'{HcpConfirmationEmail}')]")));

        }

    }
}
