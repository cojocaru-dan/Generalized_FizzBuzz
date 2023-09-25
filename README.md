# Generalized-FizzBuzz

### In this project we try to implement the famous programming excercise called FizzBuzz in OOP form.

### The rules of FizzBuzz game are very simple.
### Given a number, the algorithm needs to decide the following:
### •	If the number is divisible by 3, return Fizz.
### •	If the number is divisible by 5, return Buzz.
### •	If the number is divisible by 3 and 5, return FizzBuzz.
### •	If none of the conditions is true, return the original number as a string.

### We have to develop the solution in a generalized way, meaning that we can specify any number of different divisibility rules. For example, it must be possible to create a FizzBuzz-type game for the numbers 3, 4, and 6 with a different set of return values.

### The FizzBuzz excercise is basically an association between a list of numbers used as divisors and a string to be returned when a given number can be divided by all of the divisors. This generalized rule is the following in pseudo-code: If number x is divisibly by [divisor1, divisor2...], return string 'abc'

### To make the implementation even more flexible, we include the possibility to change the relation between the divisors, for example, to add a rule that the input number is divisible by divisor1 or divisor2.

### What are we going to learn?
### •	Use C# records.
### •	Use nullable value types in C#.
### •	Understand constructor overloading.
### •	Understand Single Responsibility Principle.
### •	Understand Interface Segregation Principle.
### •	Use collections: SortedList.
