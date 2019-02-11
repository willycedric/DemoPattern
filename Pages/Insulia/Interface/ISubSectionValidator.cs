using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.HCP;
using OpenQA.Selenium;
using FluentPageObjectPattern.StepHelpers;
using System;

namespace FluentPageObjectPattern.Pages.Insulia.Interface
{
    interface ISubSectionValidator
    {
        void IsEditedInfomationsMatch( SettingsPageElementMap Map, EditSectionFields hcpInformations, Func<IWebElement, string, bool> performCheck);

    }
}
