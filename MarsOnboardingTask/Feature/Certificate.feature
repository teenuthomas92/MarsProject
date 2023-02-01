Feature: Certificate

As a SkillSwap portal seller
I would like to Add,Edit and Delete certificate in profile details
So that I can manage Certificate in profile page successfully 
short summary of the feature


Scenario: Add Certificate in profile details
Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Certificate in Profile details can be added
	Then  Certificate are added successfully

	Scenario Outline: Edit Certificate in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Certificate in Profile details can be edited
	Then  Certificate are edited successfully

	Scenario Outline: Delete Certificate in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Certificate in Profile details can be deleted
	Then  Certificate are deleted successfully
