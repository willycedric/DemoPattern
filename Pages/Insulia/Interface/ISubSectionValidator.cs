using DemoPattern.Core;
using DemoPattern.Pages.Insulia.HCP;
using OpenQA.Selenium;
using DemoPattern.StepHelpers;
using System;

namespace DemoPattern.Pages.Insulia.Interface
{
    interface ISubSectionValidator
    {
        void IsEditedInfomationsMatch( SettingsPageElementMap Map, EditSectionFields hcpInformations, Func<IWebElement, string, bool> performCheck);

    }
}
