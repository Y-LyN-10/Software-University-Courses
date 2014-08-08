/* Problem 1. Number Checker
 Write a JavaScript function printNumbers(n) that accepts as parameter integer
 n. The function finds all integer numbers from 1 to n that are not divisible
 by 4 or by 5. Write a JS program numberChecker.js that invokes your function
 with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    function checkNumbers(number) {
        try {
            if (number <= 1) {
                throw new UserException("Input should be positive number, bigger than 1");
            } else {
                return getNotDivisibleNumbers(number);
            }
        }
        catch (error) {
            // console.log('no');
            console.log(error.message);
        }
    }

    function getNotDivisibleNumbers(number) {
        var result = [];
        while (number > 1) {
            if ((number % 4 === 0) || (number % 5 === 0)) {
                number--;
                continue;
            }
            result.push(number);
            number--;
        }

        return result.reverse().toString();
    }

    function UserException(message) {
        this.message = message;
        this.name = "UserException";
    }

    //Test the program with task example values
    var numbers = [20, 1, 13], notDivisibleNumbers, result;

    numbers.forEach(function (number) {
        notDivisibleNumbers = checkNumbers(number);
        if (notDivisibleNumbers !== undefined) {
            result = {
                number: number,
                allNotDivisibleNumbers: notDivisibleNumbers
            };

            console.log(result);
        }
    })
}());