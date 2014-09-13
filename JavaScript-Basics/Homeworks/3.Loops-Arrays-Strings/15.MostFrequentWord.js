/*  Problem 15.	Most Frequent Word
 Write a JavaScript function findMostFreqWord(value) that finds the
 most frequent word in a text and prints it, as well as how many times
 it appears in format "word -> count". Consider any non-letter character
 as a word separator. Ignore the character casing. If several words have
 the same maximal frequency, print all of them in alphabetical order.
 Write JS program frequentWord.js that invokes your function with the
 sample input data below and prints the output at the console.
 */
(function () {
    'use strict';

    var exampleStrings, mostFrequentWord, result;

    function findMostFrequentWord(string) {
        // Let's do the same like in problem 9,
        // where we found the most frequent number.
        var words = [], word,
            maxCounter = 1,
            frequencies = {},
            stringedResult = []; // xD

        words = string
            .toLowerCase()
            .match(/\b\w+\b/g)
            .sort();
//            .map( function (w) {
//                if (w in frequenties) frequenties[w] ++;
//                else frequenties[w] = 1;
//            });

        words.forEach(function (word) {
            if (frequencies[word] === undefined) {
                frequencies[word] = { word: word, times: 1 };
            } else {
                frequencies[word].times += 1;
            }

            if (frequencies[word].times > maxCounter) {
                maxCounter = frequencies[word].times;
            }
        });

        for (var i in frequencies) {
            word = frequencies[i];
            if (word.times === maxCounter) {
                stringedResult.push(word.word + ' -> ' + word.times + ' times');
            }
        }

        return stringedResult;
    }

    exampleStrings = [
        'in the middle of the night',
        'Welcome to SoftUni. Welcome to Java. Welcome everyone.',
        'Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'
    ];

    exampleStrings.forEach(function (string) {
        mostFrequentWord = findMostFrequentWord(string);
        console.log(mostFrequentWord.join('\n'));
        console.log();
    });
}());