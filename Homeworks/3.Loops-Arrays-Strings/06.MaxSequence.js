/*  Problem 6. Maximal Sequence
 Write a JavaScript function findMaxSequence(value) that finds the maximal
 sequence of equal elements in an array and returns the result as an array.
 If there is more than one sequence with the same maximal length, print the
 rightmost one. Write JS program sequenceFinder.js that invokes your function
 with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    function findMaxSequence(numbers) {
        var currentSequence = 1,
            longestSequence = 1,
            maxSeqNum = numbers[0];


        numbers.forEach(function (number, i, numbers) {
            if (numbers[i - 1] === number) {
                currentSequence++;
                if (currentSequence >= longestSequence) {
                    longestSequence = currentSequence;
                    maxSeqNum = numbers[i];
                }
            }
            else {
                currentSequence = 1;
            }
        });

// create arr with the results
        var result = [];
        for (var i = 0; i < longestSequence; i++) {
            result.push(maxSeqNum);
        }
    }


}());
/*
 Input	                          Output
 [2, 1, 1, 2, 3, 3, 2, 2, 2, 1]	  [2, 2, 2]
 ['happy']	                      ['happy']
 [2, 'qwe', 'qwe', 3, 3, '3']	  [3, 3]
 */
