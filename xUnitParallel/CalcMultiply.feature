﻿Feature: CalcMultiply
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario: Multiply two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press multiply
	Then the result should be 3500 on the screen
