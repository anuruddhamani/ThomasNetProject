Feature: Sales DashBoard Feature for Reports


Scenario: 01. To test the Login Funtionality and Click on the Reports
	Given User should be landed sucessfully on the home page as with the provided url
	When User Clicks on the login with SalesForce link
	Then user should navigate to the credentials page
	When Enter username and password
	And Click on the login button
	Then User should successfully landed to the Main Page
	When User clicks on the Reports link
	Then User should be landed successfully for reports page
	When User clicks on the Sales Activity link
	Then User should be landed successfully for Sales Activity page
	
	

Scenario: 02. User should be able to verify the text present in the PDF/PRINT

	When User clicks on the View Reports link
	Then User should be able to verify pdf succesfully
	#Then user should be verify that PDF data/content is validated








#Scenario: 03. To test the Report Functionality click on Report and click on Dare
			#When User should be able to click on dare
			#Then User should be landed successfully for dare page
			#When User clicks on the View Reports link for dare
			#Then Then user should be verify that PDF data/content is validated of dare 


#Scenario: 04. User should be able to verify all the text of Output Type present in the PDF/PRINT
	#Given User should be landed sucessfully on the View Report page as with the provided url
	#When User scrool horizontal
	#When User clicks on the Output Type
	#Then User Select HTML (Paginated) option
	#Then user should be see all options
	#Then user should be click on the option

	




	


