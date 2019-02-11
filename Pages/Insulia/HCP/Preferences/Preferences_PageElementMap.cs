using FluentPageObjectPattern.Core;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using FluentPageObjectPattern.StepHelpers;
using OpenQA.Selenium.Support;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class Preferences_PageElementMap: BasePageElementMap
    {

        public IWebElement HCPLanguageSelector
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfileLanguagesUnitEdit_ddlLanguage")));
            }
        }

        public IWebElement HCPInputFieldBasedOnValue(string targetedValue)
        {
            return BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//[@value='{targetedValue}']")));
        }

        public IWebElement HCPInputFieldBasedLabel(string targetedValue)
        {
            var tt = BrowserWait.Until((Browser) => Browser.FindElement(By.XPath($"//*[label='{targetedValue}']")));
                return tt;
        }

        public IWebElement HCPEditPreferenceSaveButton
        {
             get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfileLanguagesUnitEdit_btnSave")));
            }
        }

        public IWebElement HCPGoToEditPreferenceButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfileLanguagesUnit_btnEdit")));
            }
        }


    }
}
