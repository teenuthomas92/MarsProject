Feature: Education

As a SkillSwap portal seller
I would like to Add,Edit and Delete Education in profile details
So that I can manage Education in profile page successfully 
short summary of the feature


Scenario:  Add Education in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Education in Profile details can be added
	Then  Education are added successfully

	Scenario Outline: Edit Education in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Education in Profile details can be edited
	Then  Education are edited successfully

    Scenario Outline: Delete Education in profile details
	Given I logged into the SkillSwap portal successsfully
	And   I navigate to the Profile details 
	When  I checked whether the Education in Profile details can be deleted
	Then  Education are deleted successfully
