using DemoPattern.Core;
using OpenQA.Selenium;
namespace DemoPattern.Pages.Insulia.HCP
{
    class EditProfile_PageElementMap : BasePageElementMap
    {

        public IWebElement HCPEditProfileButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_btnEdit")));
            }
        }

        public IWebElement HCPEditLastNameField
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_txtLastNameValue")));
            }
        }

        public IWebElement HCPEditFistNameField
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_txtFirstNameValue")));
            }
        }

        public IWebElement HCPEditPhoneNumberField
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_txtPhoneNumberValue")));
            }
        }

        public IWebElement HCPEditEmailField
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_txtEmailValue")));
            }
        }

        public IWebElement HCPEditConfirmationEditField
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_txtEmailConfirm")));
            }
        }

        public IWebElement HCPEditProfileCancelButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_btnCancel")));
            }
        }

        public IWebElement HCPEditProfileSaveButton
        {
            get
            {
                return BrowserWait.Until((Browser) => Browser.FindElement(By.Id("cphMain_cphWebParts_DoctorMyProfile_btnSave")));
            }
        }
    }
}
