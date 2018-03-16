Feature: Sales DashBoard Feature for Accounts


Scenario: 01. To test the Login Funtionality and Click on the Jeopardy Accounts
	Given User should be landed sucessfully on the home page as with the provided url
	When User Clicks on the login with SalesForce link
	Then user should navigate to the credentials page
	When Enter username and password
	And Click on the login button
	Then User should successfully landed to the Main Page
	When User clicks on the JeoPardy Accounts link
	Then User should be landed successfully for jeopardy accounts page

Scenario: 02. User should be successfully lands to the Jeopardy Specfic Acccount
	When user clicks on any of the account listed
	Then user should be navigates to the correct page

Scenario: 03. User should be able to verify the text present in the PDF/PRINT
	When User clicks on the Invoices/Payments link
	And click on the PDF link
	Then user should be verify that PDF data is validated
	When Now, user clicks on the Recon link
	And Click on the Print button	
	Then user verifies the data
	

	
	
	
	

	
	
	

 

	






