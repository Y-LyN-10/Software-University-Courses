/*  Problem 14. Palindromes
 Write a JavaScript function findPalindromes(value) that extracts from a given text
 all palindromes, e.g. "ABBA", "lamal", "exe". Write JS program palindromesExtract.js
 that invokes your function with the sample input data below and prints the output at the console. */
(function () {
    'use strict';

    var exampleString, result;

    function findPalindromes(string) {
        var palindromes = [],
            words = string
                .toLowerCase()
                .replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g, '')
                .split(' ');

        // I just love chaining :3
        words.forEach(function (word) {
            if (word === word.split('').reverse().join('')) palindromes.push(word);
        });

        return palindromes;
    }

    exampleString = 'There is a man, his name was Bob.';
    result = findPalindromes(exampleString);

    console.log(result.join(', '));
}());