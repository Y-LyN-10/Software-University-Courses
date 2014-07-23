(function () {
    'use strict';

    function onvertDigitToWord(floatNumber){

        //TODO... write the program logic

        return '';
    }

    //Get a random floating value from 0 to 10, using chance.js library to test the program
    var randomNumber, digitAsWord, i;
    for(i = 0; i < 5; i+=1){
        randomNumber= chance.integer({min: 0, max: 10});
        digitAsWord = onvertDigitToWord(randomNumber);

        console.log(randomNumber + ' -> ' + digitAsWord);
    }
}());