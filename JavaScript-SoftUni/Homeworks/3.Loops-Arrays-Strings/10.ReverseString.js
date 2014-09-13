/*  Problem 10. Reverse String
 Write a JavaScript function reverseString(value) that reverses string
 and returns it. Write JS program stringReverser.js that invokes your
 function with the sample input data below and prints the output at the console.   */
(function () {
    'use strict';

    var exampleStrings, reversed, result;

    function reverseString(string) {
        var words, reversedWord,
            output = [], i;

        words = string.split(' ')
            .filter(Boolean)
            .forEach(function (word) {
                reversedWord = [];
                for (i = 0; i < word.length; i += 1) {
                    reversedWord[i] = word[word.length - 1 - i];
                }
                output.push(reversedWord.join(''));
            });

        return output.reverse().join(' ');
    }

    exampleStrings = ['sample', 'softUni', 'java script'];

    exampleStrings.forEach(function (string) {
        reversed = reverseString(string);
        result = {
            string: string,
            reversed: reversed
        };
        console.log(result);
    });
}());