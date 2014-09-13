(function () {
    'use strict';

    function isBiggerThanNeighbors(index, numbers) {
        if (index === 0 || index === numbers.length - 1) {
            return 'only one neighbor';
        } else if (index > numbers.length - 1) {
            return 'invalid index';
        } else if (numbers[index - 1] < numbers[index]
            && numbers[index] > numbers[index + 1]) {
            return 'bigger'
        } else {
            return 'not bigger';
        }
    }

    //Test with the examples from the task
    var testNumbers = [
            [2, [1, 2, 3, 3, 5]], // not bigger
            [2, [1, 2, 5, 3, 4]], // bigger
            [5, [1, 2, 5, 3, 4]], // invalid index
            [0, [1, 2, 5, 3, 4]]  // only one neighbor
        ],
        isBigger, j, index, numbers, result;

    for (j = 0; j < testNumbers.length; j += 1) {
        isBigger = isBiggerThanNeighbors(testNumbers[j][0], testNumbers[j][1]);
        result = {
            index: testNumbers[j][0],
            numbers: testNumbers[j][1].toString(),
            isBigger: isBigger
        };
        console.log(result);
    }
}());