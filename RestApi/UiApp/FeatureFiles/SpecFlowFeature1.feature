Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Incorrect password
Given User is log in
	When I click on settings
	And I enter incorrect password
	When I click Ok button
	Then A alert message should be displayed 

