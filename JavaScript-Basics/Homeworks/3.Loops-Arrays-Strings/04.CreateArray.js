/*  Problem 4. Create Array
 Write a JavaScript function createArray(value) that allocates array of 20 integers
 and initializes each element by its index multiplied by 5. Write JS program arrayBuilder.js
 that invokes your function with the sample input data below and prints the output at the console. */
(function () {
    'use strict';

    function createArray(length) {
        var array = [];

        while (length > 0) {
            array.push(length * 5);
            length--;
        }

        return array.reverse();
    }

    var createdArray = createArray(20);
    console.log(createdArray);
}());