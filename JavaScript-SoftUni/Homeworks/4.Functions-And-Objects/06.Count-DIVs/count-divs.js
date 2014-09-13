(function () {
    'use strict';

    function countDivs() {
        return document.querySelectorAll('div').length;
    }

    console.log(countDivs());
}());

//It could be written in 1 line, but in the task is said that there should be a function, etc... blaah