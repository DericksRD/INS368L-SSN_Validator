
# Requirements Specification

How to validate SSN (Social Security Number).  
The valid SSN must satisfy the following conditions:  
- It should have 9 digits.  
- It should be divided into 3 parts by hypen (-).  
- The first part should have 3 digits and should not be 000, 666, or between 900 and 999.  
- The second part should have 2 digits and it should be from 01 to 99.  
- The third part should have 4 digits and it should be from 0001 to 999.

## Software Behavior

When the program is executed, it needs to behave with the following steps:  
1. The application will ask for the SSN number.
2. The application needs to return whether the input is valid or not.
  1. If it's valid, the program will finish.
  2. If it's not, the program should explain to the user why.

## Development Insight

- It will be a document with all Case Scenarios that need to be tested.  
- The program will be created using C#, with .Net 6. The code will be written in Visual Studio Code.
- The format validation can be develop using Regular Expressions (Regex).

## Deployment Insight

- Those Sceneraios will be manually tested by de developer, confirming the code works as expected.
- It will be a Readme document in the GitHub repository. It includes the user's manual.
