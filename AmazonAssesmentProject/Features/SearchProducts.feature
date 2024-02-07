Feature: SearchProducts
In Order to test search functionality on Amazon
as a user I want to ensure search functionality
for multiple products		

@tag1
Scenario: Validate amazon logo and search functionality 
	Given I have navigated to Amazon website
	And I have entered <Search Product> in search input
	When I press the search button
	Then I validate Amazon logo in top left corner
	And I validate <Expected result> in Search result info bar
	Examples:
	| Search Product|  Expected result |
	| Toy           |       Toy        |
	| Phone         |      Phone       |