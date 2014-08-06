var Person = Object.create({
    init: function (firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        return this;
    },
    toString: function () {
        return this.firstName + ' ' + this.lastName + '(age ' + this.age + ')';
    }
});

/* From the original task:
 * var persons = {
 people.push(new Person("Scott", "Guthrie", 38));
 ...
 I'm not surprised that this input doesn't even work...
 So, I'll write it in my own way. :) */

var people = [
    Object.create(Person).init('Scott', 'Guthrie', 38),
    Object.create(Person).init('Scott', 'Johns', 36),
    Object.create(Person).init('Scott', 'Hanselman', 39),
    Object.create(Person).init('Jesse', 'Liberty', 57),
    Object.create(Person).init('Jon', 'Skeet', 38)
];