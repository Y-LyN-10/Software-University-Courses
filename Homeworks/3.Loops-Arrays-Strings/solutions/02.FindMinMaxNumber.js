/*  Problem 2. Find Min and Max Number
    Write a JavaScript function findMinAndMax(value) that accepts as parameter
    an array of numbers. The function finds the minimum and the maximum number.
    Write a JS program minMaxNumbers.js that invokes your function with the
    sample input data below and prints the output at the console.  */

function findMinAndMax(exampleArray){
    'use strict';

    var min, max;

    exampleArray.sort(function(a, b){return a-b});
    min = exampleArray[0];
    max = exampleArray[exampleArray.length-1];
    return 'Min -> ' + min + ' Max -> ' + max;
}