Feature: Sales DashBoard Home Feature
Scenario: 01. To test the Sales Activity links Click on Content Maintenance link
	Given User should be landed sucessfully on the home page as with the provided url
	When User Clicks on the login with SalesForce link
	Then user should navigate to the credentials page
	When Enter username and password
	And Click on the login button
	Then User should successfully landed to the Main Page
	When Click on the Content Maintenance link
	Then Check Content Maintenance text is Matching with Content Maintenance link or not 
	Then Check amount is matching with the total of new popup window
	When Click on download link
	Then Check weather downloaded file is xlsx or not

	

Scenario: 02. To test the Sales Activity links Click on Custom SPEC link	
	When User click on close button
	Then User Clicks on the Custom SPEC link
	Then user should check Content text Custom SPEC with new window's Content text Custom SPEC
	Then Check amount is matching with the total of new popup window or not
	When Click on download link for Custom SPEC
	Then Check weather downloaded file is xlsx or not for Custom SPEC


Scenario: 03. To test the Sales Activity links Click on Custom SPEC Implementation link
	When User click on close button
	Then User Clicks on the Custom SPEC Implementation link
	Then user should check Content text Custom SPEC Implementation with new window's Content text Custom SPEC Implementation
	Then Check amount is matching with the total of new popup window under SPEC Implementation link
	When Click on download link for SPEC Implementation
	Then Check weather downloaded file is xlsx or not for SPEC Implementation



Scenario: 04. To test the Pending Renewals links Click on Any available link
	When User click on close button
	Then User Click on the download link for Pending Renewals
	Then User can compare column of downloaded xlsx file
	When User click on any available link under Pending Renewals
	Then User should check Content text available in the link and new window under Pending Renewals


Scenario: 05. To test the Media Sales links Click on Any available link Under Media Sales
	Given User should be landed sucessfully on the home page as with the provided url
	When User Clicks on the login with SalesForce link
	Then user should navigate to the credentials page
	When Enter username and password
	And  Click on the login button
	Then User should successfully landed to the Main Page
	Then User should check by default drill down Internet_TSpec_TNN is displaying or not
	When User Click on the download link for Media Sales
	Then User can compare header column of downloaded xlsx file with web page header
	When User click on any available link under Media Sales as per selected drill down
	#Then User shoud check the title of webpage and opening page is matching or not 
	




