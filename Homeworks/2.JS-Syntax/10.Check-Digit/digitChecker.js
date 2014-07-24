(function () {
    'use strict';

    function checkThirdDigitIsThree(number){
        var numberAsString = number.toString();
        return numberAsString[numberAsString.length - 3] === '3';
    }

    var randomNumber, isThree, result, i;
    for(i = 0; i < 5; i+=1){
        randomNumber = chance.integer({min: 300, max: 5000});
        isThree = checkThirdDigitIsThree(randomNumber);
        result = {
            digit: randomNumber,
            isThirdDigitThree: isThree
        };

        console.log(result);
    }
}());