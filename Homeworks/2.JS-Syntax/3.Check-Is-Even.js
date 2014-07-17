/* Problem 3. Check if Number is Even
   Write a JavaScript function evenNumber(value) that checks
   if an integer number is even. Write JS program evenChecker.js
   to check if a few numbers are even. The result should be printed
   on the console (true or false). Run the program through Node.js. */

'use strict';

var isEven = function (value) {
    if (value % 2 === 0) {
        return true;
    } else {
        return false;
    }
}

//Example test values, given in the task:
console.log(isEven(3));
console.log(isEven(127));
console.log(isEven(588));

//TODO: Write a Math Random generator to test the solution :]