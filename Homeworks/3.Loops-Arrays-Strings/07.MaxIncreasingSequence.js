/*  Problem 7. Maximal Increasing Sequence
 Write a JavaScript function findMaxSequence(value) that finds the maximal increasing
 sequence in an array of numbers and returns the result as an array. If there is no
 increasing sequence the function returns 'no'.

 Write JS program maxSequenceFinder.js that invokes your function with the sample
 input data below and prints the output at the console.  */
(function () {
    'use strict';

    var numberArrays, maxIncreasingSequence, result;

    function findMaxIncreasingSequence(numbers) {
        var currentSequence = 1,
            longestSequence = 1,
            sequenceStart;

        numbers.forEach(function (n, i, numbers) {
            if (numbers[i] < numbers[i + 1]) {
                currentSequence++;
            } else {
                if (currentSequence >= longestSequence) {
                    longestSequence = currentSequence;
                    sequenceStart = i - currentSequence + 1;
                }
                currentSequence = 1;
            }
        });

        if (longestSequence < 2) {
            return 'no';
        }
        else {
            return numbers.slice(sequenceStart, sequenceStart + longestSequence);
        }
    }

    numberArrays = [
        [3, 2, 3, 4, 2, 2, 4],
        [3, 5, 4, 6, 1, 2, 3, 6, 10, 32],
        [3, 2, 1]
    ];

    numberArrays.forEach(function (array) {
        maxIncreasingSequence = findMaxIncreasingSequence(array);
        result = {
            array: array,
            maxSequence: maxIncreasingSequence
        };

        console.log(result);
    });

}());


