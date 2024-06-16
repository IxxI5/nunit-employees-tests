# EmployeeManager Testing with NUnit

Author: IxxI5

### Description

EmployeeManager Testing with NUnit
Each test method follows the Arrange-Act-Assert pattern to clearly separate the setup, execution, and verification phases of the tests.This example demonstrates unit testing in C# using NUnit for an EmployeeManager class that manages a list of employees. The EmployeeManager class includes operations such as adding, removing, and retrieving employees, as well as calculating total and average salaries. The accompanying EmployeeManagerTests class contains a variety of NUnit tests to validate these operations. 

Key features of the example include:

- Setup and Teardown: Initializes and cleans up resources before and after each test.
- Basic Tests: Verifies the correctness of operations such as adding, removing, and retrieving employees.
- Exception Testing: Ensures proper exception handling, such as handling null employees and calculating averages with no employees.
- Parameterized Tests: Utilizes NUnit's [TestCase] attribute to run multiple test cases with different inputs.
