// Problem 1. Number Checker
// Write a JavaScript function printNumbers(n) that accepts as parameter integer n.
    // The function finds all integer numbers from 1 to n that are not divisible
    // by 4 and 5 at the same time. Write a JS program numberChecker.js that invokes
// your function with the sample input data below and prints the output at the console.

'use strict';

var NOT_DIVISIBLE_BY = [4, 5];

var productNotToDivideBy = function (NOT_DIVISIBLE_BY) {
    var product = 1;

    for (var index in NOT_DIVISIBLE_BY) {
        product *= NOT_DIVISIBLE_BY[index];
    }

    return product;
};

var printNumbers = function (number) {
    var notDivisibleNumbers, index;
    if (number <= 1) {
        console.log('no');
        return 'no';
        // TODO: throw an exception
    } else {
        notDivisibleNumbers = getNotDivisibleNumbers(number, productNotToDivideBy(NOT_DIVISIBLE_BY));
        for (index in notDivisibleNumbers) {
            console.log(notDivisibleNumbers[index]);
        }
    }
}

var getNotDivisibleNumbers = function (number, productNotToDivideBy) {
    var result = [], i, j;
    for (i = 2, j = 0; i <= number; i += 1) {
        if (i % productNotToDivideBy != 0) {
            result[j] = i;
            j++;
        }
    }

    return result;
};

console.log(printNumbers(20));

//Examples:
//input 20	output  2, 3, 6, 7, 9, 11, 13, 14, 17, 18, 19
//input 1	output 	no
//input 13	output  2, 3, 6, 7, 9, 11, 13