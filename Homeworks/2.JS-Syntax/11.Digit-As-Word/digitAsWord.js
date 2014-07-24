(function () {
    'use strict';

    function onvertDigitToWord(digit){

      return;
    }

    var randomDigit, digitAsWord, i;
    for(i = 0; i < 5; i+=1){
        randomDigit= chance.integer({min: 0, max: 10});
        digitAsWord = onvertDigitToWord(randomDigit);

        console.log(randomNumber + ' -> ' + digitAsWord);
    }
}());