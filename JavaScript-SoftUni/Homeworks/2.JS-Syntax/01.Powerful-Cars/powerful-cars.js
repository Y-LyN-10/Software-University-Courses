(function () {
    'use strict';

    function convertKWtoHP(kilowatts) {
        var ONE_HORSEPOWER = 0.745699872;

        return (kilowatts / ONE_HORSEPOWER).toFixed(2);
    }

    //Get a random floating value from 40 to 200, using chance.js library.
    //It's cool and can be used for many things ^^ -> http://chancejs.com/
    var i, kilowatts, horsepower , result;
    for (i = 0; i < 5; i += 1) {
        kilowatts = chance.integer({min: 20, max: 200, fixed: 2});
        horsepower = convertKWtoHP(kilowatts);
        result = {
            kilowatts: kilowatts,
            horsepower: horsepower
        };

        console.log(result);
    }
}());