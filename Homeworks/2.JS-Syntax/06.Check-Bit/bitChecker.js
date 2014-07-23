(function () {
    'use strict';

    function checkThirdBitIsOne(number){

        //TODO... write the program logic

        return false;
    }

    //Get a random integer number from 0 to 1000, using chance.js library to test the program
    var randomNumber, testResult, i;
    for(i = 0; i < 5; i+=1){
        randomNumber = chance.integer({min: 0, max: 1000});
        testResult = checkThirdBitIsOne(randomNumber);

        console.log(randomNumber + ' -> is the third bit 1? -> ' + testResult);
    }
}());