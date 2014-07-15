'use strict';

var round, floor;

var roundNumber = function(number){

    floor = Math.floor(number);
    round = Math.round(number);

    console.log(floor + ' ' + round + '\n');
}

console.log('Test 1: ');
roundNumber(22.7);

console.log('Test 2: ');
roundNumber(12.3);

console.log('Test 3: ');
roundNumber(58.7);

