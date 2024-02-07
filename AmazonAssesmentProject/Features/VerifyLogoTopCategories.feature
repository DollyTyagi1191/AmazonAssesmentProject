Feature: VerifyLogoTopCategories
In Order to verify image logo on Amazon site
as a user I want to verify logo for selected categories

@tag1
Scenario: Validate image logo for selected categories
	Given I have navigated to Amazon website
	And I have selected hamburger menu button from the navigation bar
	When I select Mobiles, Computers options
	And I select Software option
	Then I validate logo is present under Top categories section