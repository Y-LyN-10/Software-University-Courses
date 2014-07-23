(function () {
    'use strict';

    function checkIsEven(value) {
        var isEven = false;

        if (value % 2 === 0) {
           isEven = true;
        }
        //I know that I should return only 'true' or 'false', but when the number
        //is random and we don't know it, we can't see if the program works correctly.
        return value + ' -> ' + isEven;
    }

    //Get a random integer value, using chance.js library.
    for(var i = 0; i < 10; i+=1){
        console.log(checkIsEven(chance.integer({min: -9999, max: 9999})));
    }
}());
