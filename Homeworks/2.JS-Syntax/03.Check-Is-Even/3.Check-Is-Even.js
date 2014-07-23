(function () {
    'use strict';

    function checkIsEven(number) {

        if (number % 2 === 0) {
            return true;
        }

        return false;
    }

    //Get a random integer value, using chance.js library to test the program
    var randomNumber, isEven, i;
    for(i = 0; i < 5; i+=1){
        randomNumber = chance.integer({min: -9999, max: 9999});
        isEven = checkIsEven(randomNumber);

        console.log(randomNumber + ' -> isEven? -> ' + isEven);
    }
}());
