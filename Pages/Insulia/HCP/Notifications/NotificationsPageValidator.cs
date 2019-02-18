using DemoPattern.Core;
using FluentAssertions;

namespace DemoPattern.Pages.Insulia.HCP
{
    class NotificationsPageValidator:BasePageValidator<NotificationsPage, NotificationsPageElementMap, NotificationsPageValidator>
    {
        public NotificationsPage IsNotificationPageDisplayed()
        {
            WrapValidators(() =>
            {
                Map.NotificationPageTitle.Displayed.Should().Be(true);
            });
            return PageInstance;
        }
    }
}
