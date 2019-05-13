Feature: WeatherAPI
	In order to get weather information
	As a user
	As a math idiot
	I want to be get weather information from API

@api
Scenario: Verify weather API with city name
	Given I have endpoint 'http://restapi.demoqa.com/utilities/weather/city/'
	When I have add city 'Pune'
	Then I get weather information for 'Pune'

	Scenario: verify weather API with zip code
	Given  I have endpoint 'http://restapi.demoqa.com/utilities/weather/city/zipcode'
	When I have add zip code '414105'
	Then I get weather information zip code for 'Ahmadnagaar'


	Scenario Outline: verify weather API with city and Zip code 
	Given  I have endpoint 'http://restapi.demoqa.com/utilities/weather/city/'
	When I  enter Parameter '<Parameter>'
	Then I get weather information '<result>'
	Examples:
	| Parameter  | result                                                  |
	| Pune       | Pune                                                    |
	| 4123512765 | An internal error occured while servicing the request   |
	| 0000       | An internal error occured while servicing the request   |
	| 414105     | Ahmadnagar                                              |
	|            | Invalid or Missing GET data, please correct the request |