(function () {
    'use strict';

    function checkIsPrime(number){

        //TODO... write the prime checker logic

        return false;
    }

    //Get a random integer number from 0 to 1000, using chance.js library to test the program
    var randomNumber, testResult, i;
    for(i = 0; i < 5; i+=1){
        randomNumber = chance.integer({min: 0, max: 1000});
        testResult = checkIsPrime(randomNumber);

        console.log(randomNumber + ' -> isPrime? -> ' + testResult);
    }
}());