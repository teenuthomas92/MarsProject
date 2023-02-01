Feature: Skill

As a SkillSwap portal seller
I would like to Add,Edit and Delete skill in profile details
So that I can manage Language in profile page successfully 
short summary of the feature

Scenario: Add Skill in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Skill in Profile details can be added
	Then  Skill are added successfully

	Scenario Outline: Edit Skill in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Skill in Profile details can be edited
	Then  Skill are edited successfully

	Scenario Outline: Delete Skill in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Skill in Profile details can be deleted
	Then  Skill are deleted successfully