Feature: Certifications
	
	As a seller I would like to add the Cretifications I have received, so that my customers would know about my acheivements.
@mytag

Scenario: Add Certification
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Fill-in all the certification details
	Then I should be able see my certification details on the profile page.
	
	Scenario: Add Certification leaving certificate text box blank
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Fill-in all the certification details except certificate/Award text box
	Then I should get the message saying enter cerfication name, certification from and certification year

	Scenario: Add Certification leaving certified from text box blank
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Fill-in all the certification details except certified from text box
	Then I should get the message saying enter cerfication name, certification from and certification year

	Scenario: Add Certification without selecting year
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Fill-in all the certification details except year
	Then I should get the message saying enter cerfication name, certification from and certification year

	Scenario: Edit Certificate Textbox
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Edit the certificate/Award text box
	Then I should be able see my edited certification details on the profile page.

	Scenario: Edit Certified From Textbox
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Edit the certified from text box
	Then I should be able see my edited certified from details on the profile page.

	Scenario: Edit year Textbox
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Edit the year 
	Then I should be able see my edited year details on the profile page.

	Scenario: Delete Certification
	Given  Given Logged into the Profile Page & Selected the Certification Button
	When Delete the certification details
	Then I should be able see my certification details deleted on the profile page.
