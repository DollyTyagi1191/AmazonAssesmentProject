Feature: VerifyLogoTopCategories
In Order to verify image logo on Amazon site
as a user I want to verify logo for selected categories

@tag1
Scenario: Validate image logo for selected categories
	Given User have navigated to Amazon website
	And User have selected hamburger menu button from the navigation bar
	When User select Mobiles, Computers options
	And User select Software option
	Then User validate logo is present under Top categories section