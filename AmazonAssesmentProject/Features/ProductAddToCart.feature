Feature: ProductAddToCart
In Order to test add to cart functionality on Amazon
as a user I want to validate item is added in the shopping cart

@tag1
Scenario:Validate add to cart functionality for selected product
	Given User have navigated to Amazon website
	And User have entered <Search Product> in search input
	When User press the search button
	And User select <Search Product > from list
	And User click add to cart button
	Then User validate added item <Search Product> is present in the shopping cart
	Examples:
	| Search Product |
	| Apple iPhone 15 Pro Max (256 GB) - Blue Titanium |