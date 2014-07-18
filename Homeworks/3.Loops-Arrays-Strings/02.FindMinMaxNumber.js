/*  Problem 2. Find Min and Max Number
    Write a JavaScript function findMinAndMax(value) that accepts as parameter
    an array of numbers. The function finds the minimum and the maximum number.
    Write a JS program minMaxNumbers.js that invokes your function with the
    sample input data below and prints the output at the console.  */

'use strict';

function findMinAndMax(exampleArray){
    var min, max;

    exampleArray.sort(function(a, b){return a-b});
    min = exampleArray[0];
    max = exampleArray[exampleArray.length-1];
    return 'Min -> ' + min + ' Max -> ' + max;
};

var exampleArray = [1, 2, 1, 15, 20, 5, 7, 31];     //Output: Min -> 1 Max -> 31
console.log(findMinAndMax(exampleArray));

/*  Examples:
    Input: [2, 2, 2, 2, 2]
    Output: Min -> 2 Max -> 2
    Input: [500, 1, -23, 0, -300, 28, 35, 12]
    Output: Min -> -300 Max -> 500 */
