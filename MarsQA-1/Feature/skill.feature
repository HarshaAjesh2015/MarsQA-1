Feature: skill
	As a seller I would like to add the skills I posses and choose the skill level so that my customers can know my skills.


@mytag
Scenario:Add new skill on the profile
	Given Logged into the Profile Page & Selected the Skills Button
	When Typed in skill text  box and chose skill level
	Then I should be able to see the updated skill on the profile page

	Scenario:Add new skill leaving add skill textbox blank
	Given Logged into the Profile Page & Selected the Skills Button
	When Choose the skill level and leave the skill textbox blank
	Then I should get a message saying please enter skill experience level

	Scenario:Add new skill and not select skill level 
	Given Logged into the Profile Page & Selected the Skills Button
	When Type the skill and do not select skill level 
	Then I should get a message saying please enter skill experience level

	Scenario:Edit skill on the profile
	Given Logged into the Profile Page & Selected the Skills Button
	When Edit skill text  box 
	Then I should get message saying the skill has been updated to your skill

	Scenario:Edit new skill on the profile
	Given Logged into the Profile Page & Selected the Skills Button
	When Edit the skill level
	Then I should get message saying the skill has been updated to your skill
	
	Scenario:Delete skill on the profile
	Given Logged into the Profile Page & Selected the Skills Button
	When Select the skill to be deleted
	Then I should be getting a message saying skill has bee deleted
