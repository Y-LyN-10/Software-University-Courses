(function () {

    // I'm using underscore library for this solution
    if (typeof require !== 'undefined') {
        _ = require('../libs/underscore.js');
    }

    var byFirstName, byLastName, byAge, result;

    byFirstName = _.chain(people)
        .groupBy(function (p) { return p.firstName })
        .map(function (p) { return 'Group ' + p[0].firstName + ' : [' + p + ']'})
        .value();

    byLastName = _.chain(people)
        .groupBy(function (p) { return p.lastName })
        .map(function (p) { return 'Group ' + p[0].lastName + ' : [' + p + ']' })
        .value();

    byAge = _.chain(people)
        .groupBy(function (p) { return p.age })
        .map(function (p) { return 'Group ' + p[0].age + ' : [' + p + ']' })
        .value();

    function group(key) {
        if (key === 'firstName') {
            result = byFirstName;
        } else if (key === 'lastName') {
            result = byLastName;
        } else if (key === 'age') {
            result = byAge;
        } else {
            throw new Error('Invalid key');
        }

        console.log(result.toString());
    }

    group('firstName');
    group('lastName');
    group('age');
}());