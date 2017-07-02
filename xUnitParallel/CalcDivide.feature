Feature: CalcDivide
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario: Divide two numbers
	Given I have entered 120 into the calculator
	And I have also entered 2 into the calculator
	When I press divide
	Then the result should be 60 on the screen
