/*  Problem 3. Current Time
    Write a JavaScript program current-time.js that prints on the console the current
    time in format hours:minutes. The hours should be printed without leading zeroes.
    The minutes should be printed as two-digit number with a leading zero when needed.
    Execute your program through Node.js. */

'use strict';

var currentDateTime = new Date();

var hours = currentDateTime.getHours();
var minutes = currentDateTime.getMinutes();

if (minutes < 10) {
    minutes = '0' + minutes;
}

var currentTime = hours + ":" + minutes;
console.log(currentTime);