Feature: ProductAddToCart
In Order to test add to cart functionality on Amazon
as a user I want to validate item is added in the shopping cart

@tag1
Scenario:Validate add to cart functionality for selected product
	Given I have navigated to Amazon website
	And I have entered <Search Product> in search input
	When I press the search button
	And I select <Search Product > from list
	And I click add to cart button
	Then I validate added item is present in the shopping cart
	Examples:
	| Search Product |
	| Apple iPhone 15 (128 GB) - Blue |