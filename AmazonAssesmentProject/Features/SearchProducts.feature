Feature: SearchProducts
In Order to test search functionality on Amazon
as a user I want to ensure search functionality
for multiple products		

@tag1
Scenario: Validate amazon logo and search functionality 
	Given User have navigated to Amazon website
	And User have entered <Search Product> in search input
	When User press the search button
	Then User validate Amazon logo in top left corner
	And User validate <Expected result> in Search result info bar
	Examples:
	| Search Product|  Expected result |
	| Toy           |       Toy        |
	| Phone         |      Phone       |