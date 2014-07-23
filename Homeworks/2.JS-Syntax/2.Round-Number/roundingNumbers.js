(function () {
    'use strict';

    function getInteger(floatNumber){
        var round, floor, result;

        floor = Math.floor(floatNumber); //always down
        round = Math.round(floatNumber); //like in Math

        result = floatNumber + ' -> floored: ' + floor + ' rounded: ' + round;
        return result;
    }

    //Get a random floating value from 0 to 100, using chance.js library. It's cool and
    //can be used for many things. Not only numbers -> http://chancejs.com/
    for(var i = 0; i < 10; i+=1){
        console.log(getInteger(chance.floating({min: 0, max: 100, fixed: 2})));
    }
}());