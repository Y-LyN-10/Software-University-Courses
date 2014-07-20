// Problem 4. Circle Area
// Write a JavaScript function calcCircleArea(r) that takes as a parameter the radius
// of a rectangle and calculates and returns its area. Put the function in a file named
// circle-area.js. Write a HTML page circle-area.html that includes the script circle-area.js
// and calculates and prints in the page body the area of circles of size r=7, r=1.5 and r=20.

var result = document.getElementById("result");

var calcCircleArea = function (r) {
    var PI = Math.PI;
    var radius = r;

    return PI * (radius * radius);
};

/* Examples from the task:

   Input(r)	Output
   7	    153.93804002589985
   1.5	    7.0685834705770345
   20	    1256.6370614359173	*/
