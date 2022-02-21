Feature: Education
	As a seller I would like to add my education details so that my customers would know my background. 


@mytag
Scenario: Add Education
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the fields
	Then I should be able to see newly added education details on the profile page

	Scenario: Add Education leaving College/University name field blank
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the details leaving College/University name field blank
	Then I should get the message saying Please enter all the fields

	Scenario: Add Education leaving Country of College field blank
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the details leaving Country of College field blank
	Then I should get the message saying Please enter all the fields

	Scenario: Add Education leaving Title field blank
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the details leaving Title field blank
	Then I should get the message saying Please enter all the fields

	Scenario: Add Education leaving Degree field blank
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the details leaving Degree field blank
	Then I should get the message saying Please enter all the fields


	Scenario: Add Education leaving Year field blank
	Given Logged into the Profile Page & Selected the Education Button
	When Filled-in all the details leaving Year field blank
	Then I should get the message saying Please enter all the fields

	Scenario: Edit Education College/University name field 
	Given Logged into the Profile Page & Selected the Education Button
	When Select the field to be edited and edit College/University name field blank
	Then I should get the message saying Education has been updated

	Scenario: Edit Education Country of College field 
	Given Logged into the Profile Page & Selected the Education Button
	When Select the country field to be edited and edit Country of College field blank
	Then I should get the message saying Education has been updated

	Scenario: Edit Education  Title field 
	Given Logged into the Profile Page & Selected the Education Button
	When  Select the title field to be edited and edit Title field blank
	Then I should get the message saying Education has been updated

	Scenario: Edit Education Degree field 
	Given Logged into the Profile Page & Selected the Education Button
	When  Select the degree field to be edited and edit the Degree field
	Then I should get the message saying Education has been updated


	Scenario: Edit Education Year field 
	Given Logged into the Profile Page & Selected the Education Button
	When Select the year field to be edited and edit  Year field blank
	Then I should get the message saying Education has been updated

	Scenario: Delete Education 
	Given Logged into the Profile Page & Selected the Education Button
	When Select the education to be deleted
	Then I should get the message saying Education entry successfully removed