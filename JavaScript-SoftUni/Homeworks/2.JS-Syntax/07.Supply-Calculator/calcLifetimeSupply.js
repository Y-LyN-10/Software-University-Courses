(function () {
    'use strict';

    function calcLifetimeSupply(values, food) {
        var DAYS_PER_YEAR = 365,
            age = values[0],
            maxAge = values[1],
            dailyFoodAmount = values[2],
            totalYears,
            totalDays,
            totalSupplies;

        totalYears = maxAge - age;
        totalDays = totalYears * DAYS_PER_YEAR;
        totalSupplies = (totalDays * dailyFoodAmount).toFixed(2);

        return totalSupplies + 'kg of ' + food +
            ' would be enough until I am ' + maxAge +
            ' years old.';
    }

    //Test the program with task example values and random numbers
    var foods = ['chocolate', 'fruits', 'nuts', 'mandja'], //xD
        testValues = [
            [38, 118, 0.5],
            [20, 87, 2],
            [16, 102, 1.1],
            [
                chance.integer({min:0, max: 50}),
                chance.integer({min:51, max: 110}),
                chance.floating({min:0, max:3, fixed:2})
            ]
        ],
        randomFood, calculated, result, i;

    for (i = 0; i < testValues.length; i += 1) {
        randomFood = foods[chance.integer({min: 1, max: foods.length - 1})];
        calculated = calcLifetimeSupply(testValues[i], randomFood);

        result = {
            age: testValues[i][0],
            maxAge: testValues[i][1],
            foodPerDay: testValues[i][2],
            food: randomFood,
            calculated: calculated
        };

        console.log(result);
    }
}());