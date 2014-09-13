/*  Problem 6. Maximal Sequence
 Write a JavaScript function findMaxSequence(value) that finds the maximal
 sequence of equal elements in an array and returns the result as an array.
 If there is more than one sequence with the same maximal length, print the
 rightmost one. Write JS program sequenceFinder.js that invokes your function
 with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    var mixedArray, maxSequence, resultTiPrint;

    function findMaxSequence(numbers) {
        var currentSequence = 1,
            longestSequence = 1,
            sequenceItem = numbers[0],
            result = [];

        numbers.forEach(function (n, i, numbers) {
            // 'n' is the same as 'numbers[i]'
            if (numbers[i - 1] === numbers[i]) {
                currentSequence++;
                if (currentSequence >= longestSequence) {
                    longestSequence = currentSequence;
                    sequenceItem = numbers[i];
                }
            } else {
                currentSequence = 1;
            }
        });

        while (longestSequence--) {
            result.push(sequenceItem);
        }

        return result;
    }

    mixedArray = [
        [2, 1, 1, 2, 3, 3, 2, 2, 2, 1], ['happy'],
        [2, 'qwe', 'qwe', 3, 3, '3'],
        [5, 4, 3, 3, '3', 3, 'test', 'test', 'test', 0, '0', '0', 0]
    ];

    mixedArray.forEach(function (array) {
        maxSequence = findMaxSequence(array);
        resultTiPrint = {
            array: array,
            maxSequence: maxSequence
        };

        console.log(resultTiPrint);
    });
}());