/*  Problem 18.	*Replace <a> Tag
 Write a JavaScript function replaceATag(value) that replaces in a HTML document
 given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 Write JS program aTagReplacer.js that invokes your function with the sample input
 data below and prints the output at the console.*/
(function () {
    'use strict';

    function replaceATag(str) {
        var re = /<a([\w\W]*)>([\w\W]*)<\/a>/gi;
        return str.replace(re, '[URL $1]$2[/URL]');
    }

    var exampleInput = '<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>';
    console.log(replaceATag(exampleInput));
}());