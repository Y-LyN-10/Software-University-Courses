/*  Problem 5. Compare Chars
 Write a JavaScript function compareChars(value) that compares two arrays
 of chars lexicographically (letter by letter). Write JS program charComparer.js
 that invokes your function with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    var result;

    function compareChars(arrayGroup) {
        var firstArr, secondArr, i;

        firstArr = arrayGroup[0];
        secondArr = arrayGroup[1];

        i = firstArr.length;

        if (i !== secondArr.length) return 'Not Equal';
        while (i--) {
            if (firstArr[i] !== secondArr[i]) return 'Not Equal';
        }

        return 'Equal';
    }

    var charArrayGroups = [
        [
            ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
            ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
        ],[
            ['3', '5', 'g', 'd'],
            ['5', '3', 'g', 'd']
        ],[
            ['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
            ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']
        ]
    ];

    charArrayGroups.forEach(function (arrayGroup) {
        result = compareChars(arrayGroup);
        console.log(result);
    });
}());