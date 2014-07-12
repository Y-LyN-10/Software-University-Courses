// Problem 3. Current Time
// Write a JavaScript program current-time.js that prints on the console
// the current time in format hours:minutes. The hours should be printed
// without leading zeroes. The minutes should be printed as two-digit number
// with a leading zero when needed. Execute your program through Node.js.

var currentTime = new Date();
var time = currentTime.getHours() + ":" + currentTime.getMinutes();
console.log(time);