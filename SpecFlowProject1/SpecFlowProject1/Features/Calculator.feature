Feature: Calculator

As a developer I wrote Calculator
Which i want to test

@tag1
Scenario: Add Number
	Given First number is 50
	And then second number is 40
	When the two methods are added
	Then the result should be 90

Scenario: Substract Number
	Given I have 50 and 60
	When I call the SubstractNumber method
	Then It should result -10
