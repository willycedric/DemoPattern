using FluentPageObjectPattern.Core;
using FluentAssertions;

namespace FluentPageObjectPattern.Pages.Insulia.HCP
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
