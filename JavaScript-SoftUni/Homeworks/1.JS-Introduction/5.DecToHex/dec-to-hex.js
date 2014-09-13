/*  Problem 5.	Decimal to Hexadecimal
 Write a JavaScript code in a Web page dec2hex.html that enters a positive integer number
 num and converts and converts it to a hexadecimal form. The input should be entered as
 JavaScript prompt window. The output should be shown as browser popup window (alert).  */

'use strict';

function convertDecToHex(decNumber) {
    var hexNumber = Number(decNumber).toString(16).toUpperCase();
    return hexNumber;
}

/* Examples, given in the task:
   Input:       Output:
   254	        FE
   6779	        1A7B
   10941298 	A6F372
   65535	    FFFF
   0	        0           */
