using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.Interface;
using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using FluentPageObjectPattern.StepHelpers;
using OpenQA.Selenium;
using System;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class SettingsPageValidator : BasePageValidator<SettingsPage, SettingsPageElementMap, SettingsPageValidator>
    {
        
        public SettingsPage IsNotificationPageDisplayed()
        {
            WrapValidators(() =>
            {
                Map.SectionProfileTitle.Displayed.Should().Be(true);
            }, Map.SectionProfileTitle);
            return PageInstance;
        }

        public SettingsPage IsEditedInfomationsMatch(string targetedSubSection, Table table, Func<IWebElement, string, bool> performCheck)
        {
            var hcpInformations = table.CreateInstance<EditSectionFields>();
            if (targetedSubSection == null || targetedSubSection.Equals(string.Empty))
                throw new ArgumentException(message: "The name of the page can't be null or empty");
            try
            {   //@TODO: Find a way to remove the Validator postfix
                var page = Activator.CreateInstance(Type.GetType(GetType().Namespace + "." + targetedSubSection+"Validator")) as ISubSectionValidator;
                page.IsEditedInfomationsMatch(Map, hcpInformations, performCheck);                
                return PageInstance;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }


    }
}
