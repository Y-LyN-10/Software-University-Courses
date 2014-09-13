(function () {
    function solve(str) {
        'use strict';
        var alphabet = '-abcdefghijklmnopqrstuvwxyz'.split(''),
            inputString = str[0].toLowerCase(),
            stringDigits = inputString.split(''), cI, cJ, // HQ Code forever!
            sum, isCombinationFound = false;

        sum = sumLetters();

        // if it starts from zero, the product will always be zero
        for (var i = 111; i < 1000; i++) {
            for (var j = 111; j < 1000; j++) {
                cI = i.toString();
                cJ = j.toString();

                if((cI[0] * cI[1] * cI[2] === sum) &&
                   (cJ[0] * cJ[1] * cJ[2] === sum)){
                   console.log(cI + '-' + cJ);
                   isCombinationFound = true;
                }
            }
        }

        function sumLetters() {
            var sum = 0;
            stringDigits.forEach(function (letter) {
                sum += alphabet.indexOf(letter);
            });
            return sum;
        }

        if(!isCombinationFound){
            console.log('No');
        }
    }

    var firstZeroTest = ['aa'];
//    var secondZeroTest = ['xz'];
//    var thirdZeroTest = ['cobazaa'];

    solve(firstZeroTest);
//    solve(secondZeroTest);
//    console.log(solve(thirdZeroTest));
}());

