(function () {
    'use strict';

    function compareAreas(values){
        var a, b, houseArea, treeArea;

        a = values[0];
        b = values[1];

        //simplified formula of square area + triangle area
        houseArea = (4*(a*a)) / 3; //Thanks to SuperVlado™
        treeArea =  Math.PI*(2/3*b)*(2/3*b) + b * (b / 3);

        return houseArea > treeArea ? 'house/' + houseArea.toFixed(2) : 'tree/' + treeArea.toFixed(2);
    }

    //Array with test examples from the task
    var testValues = [[3, 2], [3, 3], [4, 5]],
        compare, result, rn, i, j;

    //And some randoms to the array...
    for (i = 0; i < 5; i += 1) {
        rn = [
            chance.integer({min: 1, max: 10}),
            chance.integer({min: 1, max: 10})
        ];

        testValues.push(rn);
    }

    //And test
    for (j = 0; j < testValues.length; j += 1) {
        compare = compareAreas(testValues[j]);
        result = {
            a: testValues[j][0],
            b: testValues[j][1],
            cylinderVolume: compare
        };

        console.log(result);
    }
}());