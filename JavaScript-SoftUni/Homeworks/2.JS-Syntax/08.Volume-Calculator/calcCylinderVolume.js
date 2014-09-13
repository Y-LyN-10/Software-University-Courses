(function () {
    'use strict';

    function calcCylinderVolume(values){
        var radius = values[0],
            height = values[1],
            volume;

        volume = height * Math.PI * (radius*radius);
        return volume.toFixed(3);
    }

    //Array with test examples from the task
    var testValues = [[2, 4], [5, 8], [12, 3]],
        cylinderVolume, result, rn, i, j;

    //And some randoms to the array...
    for (i = 0; i < 5; i += 1) {
        rn = [
            chance.integer({min: 0, max: 50}),
            chance.integer({min: 0, max: 10})
        ];

        testValues.push(rn);
    }

    //And test
    for (j = 0; j < testValues.length; j += 1) {
        cylinderVolume = calcCylinderVolume(testValues[j]);
        result = {
            radius: testValues[j][0],
            height: testValues[j][1],
            cylinderVolume: cylinderVolume
        };

        console.log(result);
    }
}());