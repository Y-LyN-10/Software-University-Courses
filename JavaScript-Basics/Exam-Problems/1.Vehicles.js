'use strict';
function solve(params) {

    var totalWheels = parseInt(params);

    var carWheels = 4,
        truckWheels = 10,
        trikeWheels = 3;

    var count = 0,
        combinations = 0;

    var i, j, k;

    for(i = 0; i <= (totalWheels / carWheels) + 1; i++){
        for(j = 0; j <= (totalWheels / truckWheels) + 1; j++){
            for(k = 0; k <= (totalWheels / trikeWheels) + 1; k++) {
                combinations = (i * carWheels) + (j * truckWheels) + (k * trikeWheels);
                if (combinations == totalWheels){
                    count++;
                }
            }
        }
    }

    console.log(count);
}

// Zero Test 1
var s = 7; // expected output: 1

// Zero Test 2
//var s = 10; //expected output: 2

// Zero Test 3
//var s = 40; //expected output: 11

solve(s);