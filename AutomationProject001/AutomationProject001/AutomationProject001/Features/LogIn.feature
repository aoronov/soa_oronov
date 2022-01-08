Feature: LogIn

As a Registered user,
I want to be able to Log in

@positive
Scenario: Successful Log in with valid credentials
	Given I navigate to Log in page
	When I enter '' as username
	And I enter '' as password
	And I click on Submit button
	Then I should see Welcome user message