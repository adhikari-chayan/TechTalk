Feature: AccessFrameworkAnalyzer
	In order to avoid unpaid searches and applications
	I want to be sure that the user can only search and apply upto their limit
	based on their membership type

@AccessFrameworkAnalyser
Scenario: user with Free membership, already maxed searches and applications 
	Given the membershiptypes
	| MembershipTypeName | MaxSearchesPerDay | MaxApplicationsPerDay |
	| Free               | 5                 | 1                     |
	| Silver             | 10                | 10                    |
	| Gold               | 15                | 15                    |
	| Platinum           | 50                | 50                    |
	And a user
	| ID | Username | FirstName | LastName | MembershipTypeName | CurrentSearchesCount | CurrentApplicationsCount |
	| 10 | drakem   | Drake     | Moore    | Free               | 5                    | 1                         |
	When access result is required
	Then access result should be
	| CanSearch | CanApply |
	| false     | false    |


@AccessFrameworkAnalyser
Scenario: user with Free membership, still has both searches and applications 
	Given the membershiptypes
	| MembershipTypeName | MaxSearchesPerDay | MaxApplicationsPerDay |
	| Free               | 5                 | 1                     |
	| Silver             | 10                | 10                    |
	| Gold               | 15                | 15                    |
	| Platinum           | 50                | 50                    |
	And a user
	| ID | Username | FirstName | LastName | MembershipTypeName | CurrentSearchesCount | CurrentApplicationsCount |
	| 10 | drakem   | Drake     | Moore    | Free               | 4                    | 0                        |
	When access result is required
	Then access result should be
	| CanSearch | CanApply |
	| true      | true     |

	@AccessFrameworkAnalyser
Scenario: user with Free membership, still has searches but no applications available 
	Given the membershiptypes
	| MembershipTypeName | MaxSearchesPerDay | MaxApplicationsPerDay |
	| Free               | 5                 | 1                     |
	| Silver             | 10                | 10                    |
	| Gold               | 15                | 15                    |
	| Platinum           | 50                | 50                    |
	And a user
	| ID | Username | FirstName | LastName | MembershipTypeName | CurrentSearchesCount | CurrentApplicationsCount |
	| 10 | drakem   | Drake     | Moore    | Free               | 4                    | 1                         |
	When access result is required
	Then access result should be
	| CanSearch | CanApply |
	| true      | false     |


