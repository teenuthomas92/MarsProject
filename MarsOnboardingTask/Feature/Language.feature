Feature: Language

As a SkillSwap portal seller
I would like to Add,Edit and Delete language in profile details
So that I can manage Language in profile page successfully 
short summary of the feature


Scenario: Add Language in profile details
Given I logged into the SkillSwap portal successsfully
And   I navigate to the Profile details 
When  I checked whether the Language in Profile details can be addeed
Then  Language are added successfully

Scenario: Edit Language in profile details
Given I logged into the SkillSwap portal successsfully
And   I navigate to the Profile details 
When  I checked whether the Language in Profile details can be edited
Then  Language are edited successfully

Scenario: Remove Language in profile details
Given I logged into the SkillSwap portal successsfully
And   I navigate to the Profile details 
When  I checked whether the Language in Profile details can be removed
Then  Language are removed successfully

