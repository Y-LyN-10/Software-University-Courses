/*  Problem 2. Find Min and Max Number
 Write a JavaScript function findMinAndMax(value) that accepts as parameter
 an array of numbers. The function finds the minimum and the maximum number.
 Write a JS program minMaxNumbers.js that invokes your function with the
 sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    var numberArrays, minAndMaxNumbers, result;

    function findMinAndMax(numbers) {
        var min, max;

        numbers.sort(function (a, b) {
            return a - b
        });
        min = numbers[0];
        max = numbers[numbers.length - 1];
        return 'Min -> ' + min + ' Max -> ' + max;
    }

    numberArrays = [
        [1, 2, 1, 15, 20, 5, 7, 31],
        [2, 2, 2, 2, 2],
        [500, 1, -23, 0, -300, 28, 35, 12]
    ];

    numberArrays.forEach(function (array) {
        minAndMaxNumbers = findMinAndMax(array);
        result = {
            numbers: array,
            minAndMax: minAndMaxNumbers
        };

        console.log(result);
    });
}());

