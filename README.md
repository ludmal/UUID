# UUID
Simple Util function to that takes one string input of any number of
integers separated by single whitespace. The function then outputs the
longest increasing subsequence (increased by any number) present in that
sequence. If more than 1 sequence exists with the longest length, output
the earliest one. You may develop supporting functions as many as you
find reasonable.

rewrite this professionaly without any grammer mistakes
## Solution Design
* Decision to make a Console App instead of a library is a simple choice and theres no reason to back up, it is I just like to print in console
* UUID solution has been created with two projects
* It is a good practice to have a seperate project for tests hence created UUID.Tests
* A static Utility class is created called "Util" with static method. This is reduce the memory allocation and thread safety for simple cpu bound operations. We could have use Aync if the operation is invovles i/o bound but not in this case. We also could have write a Integer extensions function to simply use this one but not required in this simple test 
* Seperted out private function ```SplitToIntegers``` to encapsulate certain logic to split string. This is written as functional style to be a pure function without any side effect
* Error handling is not required since both the methods are done as Pure functions without any side effects
* Performance + Memory allocation is considerd with static functions, writing it more functional(SplitToIntegers) and Enumerable.Empty<int>().ToList()

## Documentations
* Added code comments to explain why I have taken certain decisions when I do the code.
* Also some of the comments purely to demonstrate but no value in real-life coding
* I peronsally believe, if you write self explanaroy code then can avoid lot of comments in the code

## Unit Testing
* Have added both negative/positive tests
* I have used a standard unit tests naming conventions with my personal prefference
* xUnit is used to easily use Theory with Fact to test with multiple data sets
* We could have used Shouldy for validation but left with a simple Assert

## Version Control
* Initialy created a branch to demonstrate git flow and PR
* For every simple task I have added a sequential git commit
* All the git commits follows standard feat: fix: chore: refactor: message structure


