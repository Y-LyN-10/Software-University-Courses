(function () {
    'use strict';

    function checkVariableType(variablesArray){
        var person = {
            name: variablesArray[0],
            age: variablesArray[1],
            isMale: variablesArray[2],
            favoriteFoods: variablesArray[3]
        };

        return 'My name: ' + person.name +
            ' //type is ' + typeof(person.name) +
            '\nMy age: ' + person.age +
            ' //type is ' + typeof(person.age) +
            '\nI am male: ' + (person.isMale) +
            ' //type is ' + typeof(person.isMale) +
            '\nMy favourite foods are: ' + person.favoriteFoods +
            ' //type is ' + typeof(person.favoriteFoods);
    }

    var exampleArray, result;
    exampleArray = ['Pesho', 22, true, ['fries', 'banana', 'cake']];
    result = checkVariableType(exampleArray);

    console.log(result);
}());