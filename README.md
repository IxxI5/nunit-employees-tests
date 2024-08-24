# Employee Manager Testing with NUnit

Author: IxxI5

### Description

Employee Manager Testing with NUnit
Each test method follows the Arrange-Act-Assert pattern to clearly separate the setup, execution, and verification phases of the tests.This example demonstrates unit testing in C# using NUnit for an EmployeeManager class that manages a list of employees. The EmployeeManager class includes operations such as adding, removing, and retrieving employees, as well as calculating total and average salaries. The accompanying EmployeeManagerTests class contains a variety of NUnit tests to validate these operations. 

Key features of the example include:

- Setup and Teardown: Initializes and cleans up resources before and after each test.
- Basic Tests: Verifies the correctness of operations such as adding, removing, and retrieving employees.
- Exception Testing: Ensures proper exception handling, such as handling null employees and calculating averages with no employees.
- Parameterized Tests: Utilizes NUnit's [TestCase] attribute to run multiple test cases with different inputs.

## License

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

Copyright (c) 2015 Chris Kibble

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.