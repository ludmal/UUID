# UUID
Simple Util function to that takes one string input of any number of
integers separated by single whitespace. The function then outputs the
longest increasing subsequence (increased by any number) present in that
sequence. If more than 1 sequence exists with the longest length, output
the earliest one. You may develop supporting functions as many as you
find reasonable.

## Solution Design

### Console Application Choice
The decision to develop a Console App instead of a library is straightforward, and there is no need for justification. It is solely based on the preference to print output in the console.

### UUID Solution
The UUID solution has been implemented using two separate projects.

### Test Project
In accordance with best practices, a separate project named "UUID.Tests" has been created for testing purposes.

### Utility Class
A static Utility class named "Util" with static methods has been created. This design choice aims to minimize memory allocation and enhance thread safety for simple CPU-bound operations. While asynchronous programming (Async) could have been considered for I/O-bound operations, it is not applicable in this particular case. Additionally, we have the option to create an Integer extension function for simplicity, although it is not necessary for this straightforward test.

### Encapsulation of Logic
The private function `SplitToIntegers` has been separated to encapsulate specific logic related to string splitting. This function is implemented in a functional style to maintain purity and avoid side effects.

### Error Handling
Error handling has been omitted from the code since both methods are designed as pure functions without any side effects.

### Performance and Memory Considerations
Performance and memory allocation have been taken into account by using static functions, writing the `SplitToIntegers` function in a more functional style, and leveraging `Enumerable.Empty<int>().ToList()`.

## Documentation

### Code Comments
Code comments have been added to explain the rationale behind specific decisions made during the coding process. Some comments are used for demonstration purposes but may not be necessary in a real-world coding scenario.

### Self-Explanatory Code
The belief here is that writing self-explanatory code can reduce the need for excessive comments in the codebase. 

## Unit Testing

### Test Coverage
A comprehensive set of both negative and positive tests have been included in the test suite.

### Naming Conventions
Standard unit testing naming conventions have been followed, aligning with personal preferences.

### Testing Framework
The xUnit testing framework has been utilized, allowing the use of Theory with Fact to test with multiple data sets. While Shouldy could have been an alternative for validation, a straightforward Assert approach has been employed.

## Version Control

### Git Flow
Git flow has been exemplified by initially creating a branch for the purpose of illustrating the version control process and pull request (PR) workflow.

### Sequential Git Commits
Each minor task has been committed sequentially, adhering to the standard commit message structure, which includes "feat," "fix," "chore," or "refactor" followed by a descriptive message.


