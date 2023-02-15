Feature: Profile

As a logged in user, I should be able to manage my profile information including Education, Language, Skills, and Certificates.

@Language
Scenario Outline: Add Language Information
	Given I am on the Languages tab of my profile page
	When I click on the Add New button
	And I add my language information including '<Language>', '<Level>'
	And I click on the Add button
	Then I am able to see my language details including '<Language>', '<Level>'

	Examples: 
	| Language | Level  |
	| Spanish  | Basic  |

Scenario Outline: Edit Language Information
  Given I am on the Language tab of my profile page
  When I click on the Edit icon next to the language information I want to edit
  And I modify the language information including '<Language>', '<Level>'
  And I click on the Update button
  Then the updated language information should be displayed including '<Language>', '<Level>' in the language section of my profile page 
    
	Examples: 
	| Language | Level  |
	| French  | Fluent |

	
Scenario Outline: Delete Language Information
  Given I am on Language tab of my profile page
  When I click on the Delete icon next to the language information I want to delete
 Then the deleted language information should no longer be displayed in the language section of my profile page


@Skills
Scenario Outline: Add skill Information
	Given I am on the Skill tab of my profile page
	When I click on the Add New button
	And I add my skill information including '<Skill>', '<Level>'
	And I click on the Add button
	Then I am able to see my skill details including '<Language>', '<Level>'

	Examples: 
	| Skill | Level        |
	| Java  | Intermediate |
	| C#    | Basic        |


Scenario Outline: Edit skill Information
  Given I am in the skill tab of my profile page
  When I click on the Edit icon next to the skill information I want to edit
  And I modify the skill information including '<Skill>', '<Level>'
  And I click on the Update button
  Then the updated skill information should be displayed including '<Skill>', '<Level>'the skill section of my profile page

  	Examples: 
	| Skill | Level        |
	| Java  | Intermediate |
	| C#    | Expert       |

		
Scenario Outline: Delete skill Information
  Given I am on the skill tab of my profile page
  When I click on the Delete icon next to the skill information I want to delete
  Then  The deleted skill information should no longer be displayed in the Skill section of my profile page

	
@Education
Scenario Outline: Add education Information
	Given I am on the Education tab of my profile page
	When I click on the Add New button
	And I add my education information including '<Country>', '<University>', '<Title>', '<Degree>', '<Graduation Year>'
	And I click on the Add button
	Then I am able to see my education details including '<Country>', '<University>', '<Title>', '<Degree>', '<Graduation Year>'
	
	Examples: 
    | College/University Name | Country of College/University | University | Title  | Degree          | Year of graduation |
    | Viswajyothi             | India                         | MG         | B.Tech | Graduation      | 2014               |  
    | Unitec                  | Newzealand                    | Unitec     | M.Tech | Post Graduation | 2018               |  


Scenario Outline: Edit Education Information
  Given I am on the Education tab of my profile page
  When I click on the Edit icon next to the skill information I want to edit
  And I modify the education information including '<Country>', '<University>', '<Title>', '<Degree>', '<Graduation Year>'
  And I click on the Update button
  Then the updated education information should be displayed including '<Country>', '<University>', '<Title>', '<Degree>', '<Graduation Year>' in the Education section of my profile page

  Examples: 
    | College/University Name | Country of College/University | University | Title  | Degree          | Year of graduation |
    | Viswajyothi             | India                         | MG         | B.Tech | Graduation      | 2014               |  
    | Unitec                  | china                    | Unitec     | M.Tech | Post Graduation | 2018               |  
		
Scenario Outline: Delete Education Information
  Given I am on the Education tab of my profile page
  When I click on the Delete icon next to the education information I want to delete
  Then the deleted education information should no longer be displayed in the Education section of my profile page

 
  @Certifications
Scenario Outline: Add certifications Information
	Given I am on the Certifications tab of my profile page
	When I click on the Add New button
	And I add my certifications information including '<Certificate>', '<From>', '<Year>'
	And I click on the Add button
	Then I am able to see my certifications details including '<Certificate>', '<From>', '<Year>'
	
	Examples: 
    | Certificate      | From  | Year |
    | Web Development  | Udemy | 2018 |
    | Software Testing | ISTQB | 2022 |  
    

 
Scenario Outline: Edit certifications Information
  Given I am on the Certifications tab of my profile page
  When I click on the Edit icon next to the skill information I want to edit
  And I modify the Certification information including '<Certificate>', '<From>', '<Year>'
  And I click on the Update button
  Then the updated Certifications information should be displayed including '<Certificate>', '<From>', '<Year>' in the Certification section of my profile page

Examples: 
    | Certificate      | From  | Year |
    | Machine learning  | Udemy | 2018 |
    | Software Testing | ISTQB | 2022 |  
		
Scenario Outline: Delete certifications Information
  Given I am on the Certifications tab of my profile page
  When I click on the Delete icon next to the Certifications information I want to delete
  Then the deleted certification information should no longer be displayed in the Certification section of my profile page

    
   