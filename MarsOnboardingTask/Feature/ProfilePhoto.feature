Feature: ProfilePhoto

A short summary of the feature


Scenario: Update Profile photo in profile details
Given I logged into the SkillSwap portal successsfully
And   I navigate to the Profile details 
When  I checked whether the profile photo in Profile details can be edited
Then  Profile photo are updated successsfully
