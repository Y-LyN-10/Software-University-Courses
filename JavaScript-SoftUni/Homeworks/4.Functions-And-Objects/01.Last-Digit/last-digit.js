(function () {
    'use strict';

    function findLastDigit(number) {
        var numberAsString = number.toString();
        lastDigit = numberAsString[numberAsString.length - 1];

        return lastDigit;
    }

    function convertDigitToWord(digit) {

        var digitsAsWords = [
            'Zero', 'One', 'Two', 'Three', 'Four',
            'Five', 'Six', 'Seven', 'Eight', 'Nine'
        ];

        return digitsAsWords[digit];
    }

    var randomNumber, digit, lastDigit, word, result, i;
    for (i = 0; i < 5; i += 1) {
        randomNumber = chance.integer({min: -1000, max: 20000});
        digit = findLastDigit(randomNumber);
        word = convertDigitToWord(digit);
        result = {
            digit: randomNumber,
            asWord: word
        };

        console.log(result);
    }
}());