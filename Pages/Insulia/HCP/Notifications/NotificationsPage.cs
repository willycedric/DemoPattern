using DemoPattern.Core;
using DemoPattern.Pages.Insulia.Interface;
namespace DemoPattern.Pages.Insulia.HCP
{
    class NotificationsPage: BaseFluentPageSingleton<NotificationsPage, NotificationsPageElementMap, NotificationsPageValidator>, IHCPSubPage
    {

        public void Navigate()
        {
            Map.HCPNotificationMenu.Click();
        }
    }
}
