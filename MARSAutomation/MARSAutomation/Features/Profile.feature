Feature: Profile

As a user I would like to able to Add,Update and Delete languages and Skills
So that the people seeking for skills and languages can look at what details I hold.

@Languages-Add
Scenario Outline: Add Language with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a new Language '<Language>' '<Level>'
Then the language should be added Successfully '<Language>' '<Level>'

Examples: 

| Language                                | Level          |
| English                                 | Basic          |
| @#$%^123                                | Fluent         |
| vhbhdhdbbnndmnshj235426667 jndhjrfnuijn123333 | Conversational |

@languages-AddExistingData
Scenario Outline: Adding a language that already exists
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a Language that already exists '<Language>' '<Level>'
Then the Language should not be added

Examples: 
| Language | Level  |
| English  | Fluent |

@Languages-AddInvalidData
Scenario Outline: Adding a language with invalid details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a new Language with invalid input '<Language>' '<Level>'
Then the user should see an error message

Examples: 
| Language | Level               |
|          |  Conversational     |

@Languages-CancelAdding
Scenario Outline: Cancelling adding Language
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Cancel Adding a language '<Language>' '<Level>'
Then the Language should not be added '<Language>' '<Level>'

Examples: 
| Language | Level  |
| Sanskrit  | Fluent |


@Languages-Update
Scenario Outline: Update Language with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
And I Add a new Language 
When I Update the Language '<Language>' '<Level>'
Then the language should be updated successfully '<Language>' '<Level>'

Examples: 

| Language | Level   |
| Tamil    | Fluent  |

@Languages-Delete
Scenario Outline: Delete added Language
Given I logged into the MARS Application successfully
And I navigate to Profile Page
And I Add a new Language '<Language>' '<Level>'
When I Delete the Language
Then the language should be deleted successfully '<Language>' '<Level>'

Examples: 
| Language | Level          |
| Russian  | Conversational |

@Skills-Add
Scenario Outline: Add Skills with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a new Skill '<Skill>''<Level>'
Then the Skill should be added successfully '<Skill>''<Level>'

Examples: 
| Skill                                   | Level        |
| Gardening                               | Beginner     |
| qw12$%^                                 | Intermediate |
| gsvhsbk 244556256787898 nbhjcdnsldkkjmm | Expert       |

@Skills-AddExistingSkill
Scenario Outline: Adding a Skill that already exists
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a Skill that already exists '<Skill>' '<Level>'
Then the Skill should not be added

Examples: 
| Skill     | Level        |
| Gardening | Intermediate |

@Skills-AddInvalidData
Scenario Outline: Adding a Skill with invalid details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Add a new Skill with invalid input '<Skill>' '<Level>'
Then the user should see an error message to enter Skill

Examples: 
| Skill    | Level      |
|          |  Expert    |

@Skills-CancelAdding
Scenario Outline: Cancelling adding Skills
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Cancel Adding a Skill '<Skill>' '<Level>'
Then the Skill should not be added '<Skill>' '<Level>'

Examples: 
| Skill     | Level        |
| Tennis    | Intermediate |



@Skills-Update
Scenario Outline: Update Skills with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page
When I Update a Skill '<Skill>' '<Level>'
Then the Skill should be updated successfully '<Skill>' '<Level>'

Examples: 
| Skill     | Level        |
| Badminton | Intermediate |

@Skill-Delete
Scenario Outline: Delete added Skill
Given I logged into the MARS Application successfully
And I navigate to Profile Page
And I Add a new Skill '<Skill>' '<Level>'
When I Delete the Skill
Then the Skill should be deleted successfully '<Skill>' '<Level>'

Examples: 
| Skill     | Level    |
| Swimming | Beginner |

