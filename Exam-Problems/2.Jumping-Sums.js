(function () {
    function solve(args) {
        'use strict';
        var numbers = args[0].split(' '),
            jumps = Number(args[1]),
            maxSum = 0, currentSum = 0,
            nextIndex, i = 0, j, k;

        for (k = 0; k < numbers.length; k++) {
            currentSum = Number(numbers[k]);
            i = k;
            for (j = 0; j < jumps; j++) {
                nextIndex = (i + Number(numbers[i])) % (numbers.length);
                currentSum += Number(numbers[nextIndex]);
                i = nextIndex;
            }
            if(currentSum > maxSum){
                maxSum = currentSum;
                currentSum = Number(numbers[k]);
            }
        }

        console.log('max sum = ' + maxSum);
    }

    var firstZeroTest = ['1 2 3 5', 4];

    solve(firstZeroTest);
//    solve(secondZeroTest);
//    console.log(solve(thirdZeroTest));
}());

