Feature: Products
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Verify the visibilty of states dropdown
	Given I have navigated to Products page
	And I have verified states dropdown exits
	When I press states dropdown
	Then the result should states list in dropdown
