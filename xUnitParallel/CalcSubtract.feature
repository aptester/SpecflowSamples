Feature: CalcSubtract
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario: Subtract two numbers
	Given I have entered 70 into the calculator
	And I have also entered 50 into the calculator
	When I press subtract
	Then the result should be 20 on the screen
