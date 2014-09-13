(function () {
    'use strict';

    function findYoungestPerson(people) {
        var youngestPerson, fullName, strMessage;

        youngestPerson = people.sort(function (firstPerson, secondPerson) {
            return firstPerson.age - secondPerson.age;
        })[0];

        fullName = youngestPerson.firstname + ' ' + youngestPerson.lastname;
        strMessage = 'The youngest person is ' + fullName;

        return strMessage;
    }

    // Look here! THIS is what means awful code! 'persons' ?! WTF?!
    // Totally anti-high-quality code, took from the task examples! :X
    // I didn't change it, because I'm really shocked.
    // Look at this, look and never, never write it in the same way!

    var persons = [
        { firstname: 'George', lastname: 'Kolev', age: 32},
        { firstname: 'Bay', lastname: 'Ivan', age: 81},
        { firstname: 'Baba', lastname: 'Ginka', age: 40}
    ];

    console.log(findYoungestPerson(persons));
}());