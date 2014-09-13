(function () {
    'use strict';

    function findNumberWithMaxDigitSum(numbers) {
        var result;
        var maxSum = 0;

        if (numbers.length < 2) {
            return undefined;
        }

        numbers.forEach(function (number) {
            currentSum = 0;

            if (parseInt(number) !== number) {
                return undefined;
            }

            currentNum = Math.abs(number).toString();
            currentNumDigits = currentNum.split('');

            if (currentNumDigits.length < 2) {
                return undefined;
            }

            currentNumDigits.forEach(function (digit) {
                currentSum += Number(digit);

                if (currentSum >= maxSum) {
                    result = number;
                    maxSum = currentSum;
                }
            });
        });
        return result;
    }

    //Test with the examples from the task
    var testNumbers = [
            [5, 10, 15, 111], // 15
            [33, 44, -99, 0, 20], // -99
            ['hello'], // undefined
            [5, 3.3]   // undefined
        ],
        checked, j, currentNumDigits,
        currentSum, currentNum;

    for (j = 0; j < testNumbers.length; j += 1) {
        checked = findNumberWithMaxDigitSum(testNumbers[j]);
        console.log(checked);
    }
}());