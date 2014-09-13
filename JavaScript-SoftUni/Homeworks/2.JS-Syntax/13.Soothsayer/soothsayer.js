(function () {
    'use strict';

    function soothsayer(years, languages, towns, cars){
        var randomYears, randomLanguage, randomTown, randomCar;

        randomYears = years[chance.integer({min: 0, max: years.length-1})];
        randomLanguage = languages[chance.integer({min: 0, max: languages.length-1})];
        randomTown = towns[chance.integer({min: 0, max: towns.length-1})];
        randomCar = cars[chance.integer({min: 0, max: cars.length-1})];

        return 'You will work ' +
            randomYears + ' years on ' +
            randomLanguage + '.\nYou will live in ' +
            randomTown + ' and drive ' +
            randomCar + '.';
    }

    var years = [3, 5, 2, 7, 9],
        languages = ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'],
        towns = ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'],
        cars = ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel'],
        result;

    result = soothsayer(years, languages, towns, cars);
    console.log(result);
}());