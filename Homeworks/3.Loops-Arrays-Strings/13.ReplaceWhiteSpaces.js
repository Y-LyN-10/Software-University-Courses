/*  Problem 13. Replace the White-Spaces
 Write a JavaScript function replaceSpaces(value) that replaces the white-space
 characters in a text with &nbsp;. Write JS program spaceReplacer.js that invokes
 your function with the sample input data below and prints the output at the console. */
(function () {
    'use strict';

    var exampleString, result;

    function removeWhiteSpaces(string) {
        return string.split(' ').join('');
    }

    exampleString = 'But you were living in another world tryin\' to get your message through';
    result = removeWhiteSpaces(exampleString);
    console.log(result);
}());