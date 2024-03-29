# UUID
Simple Util function to that takes one string input of any number of
integers separated by single whitespace. The function then outputs the
longest increasing subsequence (increased by any number) present in that
sequence. If more than 1 sequence exists with the longest length, output
the earliest one. 

## How to verify the functionality
* Simply open the solution and navigate to UUID.Test Project
* Goto the ```UtilTests``` file and Select ```Run All``` from your test runner window
* See the results

  ![image](https://github.com/ludmal/UUID/assets/130307/8e051abe-dacb-4e33-a896-173cf4a0bf31)

## Solution Design
* Decision to make a Console App instead of a library is a simple choice and there's no back up reason, it is I just like to print in console :-)
* UUID solution has been created with two projects
* It is a good practice to have a separate project for tests hence created UUID.Tests
* A static Utility class is created called "Util" with static method. This is reduce the memory allocation and thread safety for simple cpu bound operations. We could have used ```Async``` if the operation is involved i/o bound but not in this case. We also could have write a Integer extensions function but not required in this simple test 
* Separated out private function ```SplitToIntegers``` to encapsulate certain logic to split string. This is written as functional style to be a pure function without any side effect
* Error handling is not required since both the methods are done as Pure functions without any side effects
* Performance + Memory allocation is considered with static functions, writing it more functional(```SplitToIntegers```) and ```Enumerable.Empty<int>().ToList()```

## Documentations
* Added code comments to explain why I have taken certain decisions when I do the code.
* Also some of the comments purely to demonstrate but no value in real-life coding
* I personally believe, if you write self explanatory code then can avoid lot of comments in the code

## Unit Testing
* Have added both negative/positive tests
* I have used a standard unit tests naming conventions with my personal preference
* xUnit is used to easily use Theory with Fact to test with multiple data sets
* We could have used Shouldly.Net for validation but left with a simple Assert

## Version Control
* Initially created a branch to demonstrate git flow and PR
* For every simple task I have added a sequential git commit
* All the git commits follows standard feat: fix: chore: refactor: message structure



