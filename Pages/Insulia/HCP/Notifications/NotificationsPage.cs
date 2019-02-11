using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.Interface;
namespace FluentPageObjectPattern.Pages.Insulia.HCP
{
    class NotificationsPage: BaseFluentPageSingleton<NotificationsPage, NotificationsPageElementMap, NotificationsPageValidator>, IHCPSubPage
    {

        public void Navigate()
        {
            Map.HCPNotificationMenu.Click();
        }
    }
}
