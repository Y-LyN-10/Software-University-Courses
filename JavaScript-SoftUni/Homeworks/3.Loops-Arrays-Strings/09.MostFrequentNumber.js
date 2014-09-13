/*  Problem 9. Most Frequent Number
 Write a JavaScript function findMostFreqNum(value) that finds the most frequent
 number in an array. If multiple numbers appear the same maximal number of times,
 print the leftmost of them. Write JS program numberFinder.js that invokes your
 function with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    var numberArrays, number, result;

    function findMostFrequentNumber(numbers) {
        // We can just sort the array and get the longest sequence of equal elements
        numbers.sort();

        var equalNumbers = findMaxSequence(numbers);
        return equalNumbers[0] + ' (' + equalNumbers.length + ' times)';
    }

    // The code should be reusable, right? :}
    function findMaxSequence(numbers) {
        var currentSequence = 1,
            longestSequence = 1,
            sequenceItem = numbers[0],
            result = [];

        numbers.forEach(function (n, i, numbers) {
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

    numberArrays = [                                                    // Output:
        [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],                        // 4 (5 times)
        [2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1],     // 1 (4 times)
        [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]                     // 1 (1 times)
    ];

    numberArrays.forEach(function (array) {
        number = findMostFrequentNumber(array);

        result = {
            array: array,
            mostFrequentNumber: number
        };

        console.log(result);
    });


}());