(function () {
    'use strict';

    function divisibleByThree(number) {
        var isDivisible, sum = 0;

        number.toString()
              .split('') // in the number is negative, there remains an element with char '-'
              .filter(function (char){return char !== '-';})
              .forEach(function (digit){sum += parseInt(digit);});

        isDivisible = sum % 3 === 0;
        return isDivisible;
    }

    //Array with test examples from the task
    var testNumbers = [12, 189, 591],
        checked, result, rn, i, j;

    //And some randoms to the array...
    for (i = 0; i < 5; i += 1) {
        rn = chance.integer({min: -500, max: 1000});
        testNumbers.push(rn);
    }

    //And test
    for (j = 0; j < testNumbers.length; j += 1) {
        checked = divisibleByThree(testNumbers[j]);
        result = {
            number: testNumbers[j],
            divisibleByThree: checked
        };
        console.log(result);
    }
}());