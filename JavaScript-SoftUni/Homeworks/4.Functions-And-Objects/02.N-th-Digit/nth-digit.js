(function () {
    'use strict';

    function findNthDigit(testValues) {
        digit = testValues[0];
        number = testValues[1];

        var numberAsString = number.toString().replace('.', '').replace('-', '');

        try {
            if (numberAsString.length < digit) {
                throw new Error('The number ' + number + ' doesn’t have ' + digit + ' digits');
            } else {
                return numberAsString[numberAsString.length - digit];
            }
        } catch (err) {
            console.log(err);
        }
    }

    //Array with test examples from the task
    var testValues = [[1, 6], [2, -55], [6, 923456], [3, 1451.78], [6, 888.88]],
        nthDigit, digit, number, result, rn, i, j;

    //And some random numbers to the array...
    for (i = 0; i < 3; i += 1) {
        rn = [
            chance.integer({min: 1, max: 9}),
            chance.integer({min: -50000, max: 50000})
        ];

        testValues.push(rn);
    }

    //And some floating randoms...
    for (i = 0; i < 3; i += 1) {
        rn = [
            chance.integer({min: 1, max: 9}),
            chance.floating({min: -50000, max: 50000})
        ];

        testValues.push(rn);
    }

    //We're ready to test
    for (j = 0; j < testValues.length; j += 1) {
        nthDigit = findNthDigit(testValues[j]);

        if (nthDigit !== undefined) {
            result = {
                digit: testValues[j][0],
                number: testValues[j][1],
                NthDigit: nthDigit
            };
            console.log(result);
        }
    }
}());