Feature: LanguageFeature
	As a seller I would like to add the languages I speak and choose the language level so that my customers can communicate easily.


@mytag
Scenario: Add Language
	Given Logged into the Profile Page & Selected the Language Button
	When Typed language and chose language level
	Then I should be able to see the updated language on the profile page

	Scenario: Language textbox left blank
	Given Logged into the Profile Page & Selected the Language Button-
	When Language textbox left blank and chose language level.
	Then I should be getting a message saying 'please enter language and level'.

	Scenario: Language level not chosen
	Given Logged into the Profile Page & Selected the Language Button
	When Entered language in Language textbox  and language level is not chosen.
	Then I should be getting a message saying 'please enter language and level'.

	Scenario: Edit Language
	Given Logged into the Profile Page & Selected the Language Button.
	When Select the language to be edited
	Then I should get the message sying the language has been updated to your languages.

	Scenario: Edit Language level
	Given Logged into the Profile Page & Selected the Language Button.
	When Select the language level to be edited
	Then I should get the message sying the language has been updated to your languages.

	Scenario: Delete Language
	Given Logged into the Profile Page & Selected the Language Button
    When Selected the language to be deleted and delete the langauge
	Then I should get a message saying the language has been deleted from the languages.