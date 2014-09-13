(function () {
    'use strict';

    function getInteger(floatNumber) {
        var round, floor;

        floor = Math.floor(floatNumber); //always down
        round = Math.round(floatNumber); //like in Math

        return {
            floatNumber: floatNumber,
            floor: floor,
            round: round
        };
    }

    //Get a random floating value from 0 to 100, using chance.js library.
    var i, randomFloat, result;
    for (i = 0; i < 5; i += 1) {
        randomFloat = chance.floating({min: 0, max: 100, fixed: 2});
        result = getInteger(randomFloat);

        console.log(result);
    }
}());