using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.Interface;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using FluentPageObjectPattern.StepHelpers;
using System;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class Preferences_Page : BaseFluentPageSingleton<Preferences_Page, Preferences_PageElementMap, Preferences_PageValidator>, IHCPSectionEdition
    {

        public SettingsPage Save()
        {
            WrapStepAction(() =>
            {
                Map.HCPEditPreferenceSaveButton.Click();
            });
            return new SettingsPage();
        }

        public IHCPSectionEdition GoToTargetedSection()
        {

            Map.HCPGoToEditPreferenceButton.Click();

            return this as IHCPSectionEdition;
        }

        public IHCPSectionEdition EditTargetedSection(Table table, Action<IWebElement, string> performs)
        {
            WrapStepAction(() =>
            {
                var hcpInformations = table.CreateInstance<EditSectionFields>();
                performs(Map.HCPInputFieldBasedLabel(hcpInformations.WeightUnit), string.Empty);
                performs(Map.HCPInputFieldBasedLabel(hcpInformations.HeighUnit), string.Empty);
                performs(Map.HCPLanguageSelector, hcpInformations.Language);
            });
            return this as IHCPSectionEdition;
        }


    }
}
