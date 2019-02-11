using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.Interface;

using System;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class SettingsPage : BaseFluentPageSingleton<SettingsPage, SettingsPageElementMap, SettingsPageValidator>, IHCPSubPage
    {
        public void Navigate()
        {
            Map.HCPSettingsMenu.Click();
        }

        public IHCPSectionEdition GoToTargetedSubSection(string targetedSubSection)
        {
            if (targetedSubSection == null || targetedSubSection.Equals(string.Empty))
                throw new ArgumentException(message: "The name of the page can't be null or empty");
            try
            {
                var page = Activator.CreateInstance(Type.GetType(GetType().Namespace + "." + targetedSubSection)) as IHCPSectionEdition;
                page.GoToTargetedSection();
                return page;
            }
            catch (Exception)
            {
                throw new PageObjectNotFoundException($" The page {targetedSubSection} is not found under the namespace {GetType().Namespace}");
            }
        }
        

    }


}
