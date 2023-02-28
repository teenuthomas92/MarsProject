Feature: SignIn

 As a user, I want to be able to sign in to SkillSwap website
  So that I can access my profile and other features

Scenario: Sign in with correct credentials
  Given the user is on the sign in page
  When the user enters the correct emailaddress and password
  And clicks the Login button
  Then the user should be redirected to the profile page

Scenario Outline: Sign in with different credentials
  Given the user is on the sign in page
  When the user enters the <emailaddress> and <password>
  And clicks the Login in button
  Then the user should be <Result>

  Examples:
    | emailaddress            | password | Result                                                                         |
    | teenuthomas93@gmail.com | 121212   | redirected to the profile page                                                 |
    | teenuthomas93@gmail.com | 1234     | shown an error message "please enter a valid password "                        |
    | teenuthomas             | 121212   | shown an error message "please enter a valid email address"                    |
    |                         |          | shown an error message indicating that the username and password are requiredd |

