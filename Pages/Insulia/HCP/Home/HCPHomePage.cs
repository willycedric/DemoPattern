
using FluentPageObjectPattern.Core;
using System;
using FluentPageObjectPattern.Pages.Insulia.Interface;
namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class HCPHomePage:BaseFluentPageSingleton<HCPHomePage, HCPHomePageElementMap, HCPHomePageValidator>
    {
        private HCPStatisticsPage GoToStatisticsPage()
        {
            WrapStepAction(() =>
            {
                Map.HCPStatisticsMenu.Click();
            }, Map.HCPStatisticsMenu);
            return new HCPStatisticsPage();
        }

        private NotificationsPage GoToNotificationsMenuPage()
        {
            WrapStepAction(() =>
            {
                Map.HCPNotificationMenu.Click();
            }, Map.HCPNotificationMenu);
            return new NotificationsPage();
        }

        private SettingsPage GoToSettingsPage()
        {
            WrapStepAction(() =>
            {
                Map.HCPSettingsMenu.Click();
            }, Map.HCPSettingsMenu);
            return new SettingsPage();
        }

        /// <summary>
        /// Navigate in the HCP Portal
        /// </summary>
        /// <param name="targetedPage"></param>
        /// <returns>IHCPSubPage</returns>
        public IHCPSubPage GoToTargetedPage(string targetedPage)
        {
            if (targetedPage == null || targetedPage.Equals(string.Empty)) 
                throw new ArgumentException(message:"The name of the page can't be null or empty");
            try
            {
                var page = Activator.CreateInstance(Type.GetType(GetType().Namespace + "." + targetedPage)) as IHCPSubPage;
                page.Navigate();
                return page;
            }
            catch(Exception)
            {
                throw new PageObjectNotFoundException($" The page {targetedPage} is not found under the namespace {GetType().Namespace}");
            }
            
        }
    }
}
