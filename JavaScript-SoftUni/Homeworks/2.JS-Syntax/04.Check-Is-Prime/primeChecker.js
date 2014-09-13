(function () {
    'use strict';

    function checkIsPrime(number){
        var divider = 2,
            biggestDivisible,
            isPrime = true;

        //border case - zero is not a prime number
        if(number === 0){
            isPrime = false;
        }

        biggestDivisible= Math.sqrt(number);
        while (isPrime && (divider <= biggestDivisible)) {
            if (number % divider === 0){
                isPrime = false;
            }
            divider++;
        }

        return isPrime;
    }

    //Test examples from the task and one random number.
    var testNumbers = [7, 254, 587, 2, 1, 0],
        checked, result, rn, i, j;

    //And some randoms to the array...
    for (i = 0; i < 5; i+=1) {
        rn = chance.integer({min: -500, max: 1000});
        testNumbers.push(rn);
    }

    //And test
    for(j = 0; j < testNumbers.length; j+=1){
        checked = checkIsPrime(testNumbers[j]);
        result = {
            number: testNumbers[j],
            isPrime: checked
        };
        console.log(result);
    }
}());