/* Problem 2. Simple Calculations
   Write a JavaScript function roundNumber(value) that rounds
   floating-point number using Math.round(), Math.floor(). Write
   a JS program roundingNumbers.js that rounds a few sample values.
   Run the program through Node.js. */

'use strict';

var roundNumber, round, floor;

roundNumber = function (number) {
    floor = Math.floor(number);
    round = Math.round(number);

    console.log(floor + ' ' + round + '\n');
}

//Example test values, given in the task
roundNumber(22.7);
roundNumber(12.3);
roundNumber(58.7);