﻿using DemoPattern.Pages.Insulia.HCP;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
namespace DemoPattern.Pages.Insulia.Interface
{
     interface IHCPSectionEdition
    {
       SettingsPage  Save();

        IHCPSectionEdition EditTargetedSection(Table table, Action<IWebElement, string> performs);

        IHCPSectionEdition GoToTargetedSection();


    }
}
