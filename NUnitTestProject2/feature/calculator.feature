Feature: calculator
	In order to find calculated values
	
@web
Scenario Outline: Add two numbers 
	Given I have enter url for Calculator Page
	Then I enter first number <n1> in Calculator 
	 And I have enter '<Operation>' operator
	Then I enter second number <n2> in Calculator
	When I press equals
	Then the result should be <result> on the screen
Examples:
| n1      | Operation | n2     | result |
| 423     | Mult      | 525    | 222075 |
| 4000    | Div       | 200    | 20     |
| -234234 | Plus      | 345345 | 111111 |
| 234823  | Minus     | -23094823 | 23329646 |
