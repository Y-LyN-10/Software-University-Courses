(function () {
    function solve(args) {
        'use strict';
        var x = Number(args[0]),
            y = Number(args[1]),
            startValue = Number(args[2]),
            value = startValue,
            matrix = [[],[],[]];

        for (var i = 0; i < 3; i++) {
            for (var j = 0; j < 3; j++) {
                matrix[i][j] = value;
                if(i === y && j === x){
                    console.log(Math.pow(value, ((value + 1)- startValue )));
                }
                value ++;
            }
        }
    }

    var lastTest = [2, 2, 100];
    solve(lastTest);
}());