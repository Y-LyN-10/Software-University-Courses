(function () {
    'use strict';

    function divisibleByThree(number) {
        //If the number is divisible by three,
        //the sum of it's digits is also divisible by 3
        return number % 3 === 0;
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