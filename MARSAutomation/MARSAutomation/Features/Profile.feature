Feature: Profile

As a user I would like to able to Add,Update and Delete languages,
So that the people seeking for skills and languages can look at what details I hold.

Scenario Outline: Add Language with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a new Language '<Language>' '<Level>'
Then the language should be added Successfully '<Language>' '<level>'

Examples: 

| Language | Level |
| English  | Basic |

