using DemoPattern.Core;
using DemoPattern.Pages.Insulia.Interface;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DemoPattern.StepHelpers;
using OpenQA.Selenium;
using System;

namespace DemoPattern.Pages.Insulia.HCP
{
     class EditProfile_Page :BaseFluentPageSingleton<EditProfile_Page , EditProfile_PageElementMap, EditProfile_PageValidator>, IHCPSectionEdition
    {

        public IHCPSectionEdition GoToTargetedSection()
        {
            WrapStepAction(() =>
            {
                Map.HCPEditProfileButton.Click();
            });
          
            return this as IHCPSectionEdition;
        }
       public SettingsPage Save()
        {
            WrapStepAction(() =>
            {
                Map.HCPEditProfileSaveButton.Click();
            });
            return new SettingsPage();
        }

        public IHCPSectionEdition EditTargetedSection(Table table, Action<IWebElement, string> performs)
        {

            WrapStepAction(() =>
            {
                var hcpInformations = table.CreateInstance<EditSectionFields>();
                //Edit FirstName
                performs(Map.HCPEditFistNameField, hcpInformations.FirstName);
                //Edit LastName
                performs(Map.HCPEditLastNameField, hcpInformations.LastName);
                //Edit Email
                performs(Map.HCPEditEmailField, hcpInformations.Email);
                //Confirmation Email
                performs(Map.HCPEditConfirmationEditField, hcpInformations.ConfirmationEmail);
            });
               
            return this as IHCPSectionEdition;
        }

    
    }
}
