Feature: HCP_Navigation
 HCP must be able to navigate through all the link the page available on the portal
	Email notifications to medical team 
	- Patient list 
	- Statistics
	- Notifications
	- Settings
	- Patient details	


 @BSC
Scenario: HCP_statistic_View
	Given I login as HCP
	| UserName                | UserPassword |
	| wonder.hcp1@yopmail.com | vol+2019     |
	And I navigate to HCPStatisticsPage page 
	Then I am able to view the statistics page

@BSC
Scenario: HCP_notification_View
	Given I login as HCP
	| UserName                | UserPassword |
	| wonder.hcp1@yopmail.com | vol+2019     |
	And I navigate to NotificationsPage page 
	Then I am able to view the notification page

@BSC
Scenario: HCP_Settings_View
	Given I login as HCP
	| UserName                | UserPassword |
	| wonder.hcp1@yopmail.com | vol+2019     |
	And I navigate to SettingsPage page
	Then I am able to view Settings page

@BSC
Scenario: HCP Edit His Settings - Profile
	Given I login as HCP
	| UserName                | UserPassword |
	| wonder.hcp1@yopmail.com | vol+2019     |
	And I navigate to SettingsPage page
	Then I am able to edit hcp EditProfile_Page section informations
	| FirstName          | lastName          | Email                   | ConfirmationEmail       |
	| hcpFirstNameEdited | hcpLastNameEdited | wonder.hcp1@yopmail.com | wonder.hcp1@yopmail.com |


	Scenario: HCP Edit His Settings - Preferences
	Given I login as HCP
	| UserName                | UserPassword |
	| wonder.hcp1@yopmail.com | vol+2019     |
	And I navigate to SettingsPage page
	Then I am able to edit hcp Preferences_Page section informations
	| Language      | HeighUnit       | WeightUnit |
	| English (USA) | Feet and inches | Kilograms  |