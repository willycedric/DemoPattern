using FluentPageObjectPattern.StepHelpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FluentPageObjectPattern.Steps.HCP
{
    [Binding]
    public partial class HCPSteps
    {
        [Given(@"I login as HCP")]
        public void GivenILoginAsHCP(Table userCredentials)
        {
            var user = userCredentials.CreateInstance<UserCreadentials>();
            Pages.Insulia
                .HomePage
                .Instance
                    .GoToUrl()
                    .EnterUserLogin(userLogin: user.UserName)
                    .EnterUserPassword(userPassword:user.UserPassword)
                    .Login();
        }


        [Given(@"I navigate to (.*) page")]
        public void GivenINavigateToStatisticsMainMenu(string targetedPage) => Pages.Insulia
                 .HCP
                 .HCPHomePage
                 .Instance
                     .GoToTargetedPage(targetedPage);
  
                     
        [Then(@"I am able to view Settings page")]
        public void ThenIAmAbleToViewSettingsPage() => Pages.Insulia
            .HCP
            .SettingsPage
            .Instance
                .Validate()
                    .IsNotificationPageDisplayed();
        [Then(@"I am able to view the notification page")]
        public void ThenIAmAbleToViewTheNotificationPage() => Pages.Insulia
           .HCP
           .NotificationsPage
           .Instance
               .Validate()
                   .IsNotificationPageDisplayed();
        [Then(@"I am able to view the statistics page")]
        public void ThenIAmAbleToViewTheStatisticsPage() => Pages.Insulia
               .HCP
               .HCPStatisticsPage
               .Instance
                   .Validate()
                       .IsStatisticPageDisplayed();


        [Then(@"I am able to edit hcp (.*) section informations")]
        public void ThenIAmAbleToEditHcpProfileInformations(string targetedSubSection, Table table) => Pages.Insulia
                 .HCP
                 .SettingsPage
                 .Instance
                 .GoToTargetedSubSection(targetedSubSection: targetedSubSection)
                 .EditTargetedSection(table: table, performs: PageDelegate.FillFormEntry)
                 .Save()
                   .Validate()
                   .IsEditedInfomationsMatch(targetedSubSection: targetedSubSection, table: table, performCheck: PageDelegate.CheckFillEntry);
                    
                   
                   
                  
                

    }
}
