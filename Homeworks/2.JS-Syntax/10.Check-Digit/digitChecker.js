(function () {
    'use strict';

    function checkThirdDigitIsThree(number){

        //TODO... write the program logic

        return false;
    }

    //Get a random integer number from 1000 to 500000, using chance.js library to test the program
    var randomNumber, testResult, i;
    for(i = 0; i < 5; i+=1){
        randomNumber = chance.integer({min: 1000, max: 500000});
        testResult = checkThirdDigitIsThree(randomNumber);

        console.log(randomNumber + ' -> is the 3d digit 3? -> ' + testResult);
    }
}());