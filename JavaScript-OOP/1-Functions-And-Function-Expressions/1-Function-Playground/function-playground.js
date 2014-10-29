/* Problem 1. Function Playground
 Create a function with no parameters. Perform the following operations:
 •	The function should print the number of its arguments and each of the arguments' type. 
 o	Call the function with different number and type of arguments.
 •	The function should print the this object. Compare the results when calling the function from:
 o	Global scope
 o	Function scope
 o	Over the object
 o	Use call and apply to call the function with parameters and without parameters */

// ---- Run this code with Node.js ----

var util = require('util');
var os = require('os');

function doUselessThings() {
    if(arguments.length > 0){
        console.log(util.format(
            'Number of arguments in %s() is %d',
            doUselessThings.name, arguments.length));

        for(var key in arguments) {
            console.log(util.format(
                'Argument %d is %s (value = %s)',
                key, typeof arguments[key], arguments[key]));
        }
    } else {
        console.log(util.format('%s() is called with no arguments', doUselessThings.name));
    }

    console.log(os.EOL + '----------' + os.EOL);

//  console.log(this); // Uncomment this line after you see the other logs - it's too long.
}

var uselessData = [
    [23, 43, '22', true, false, null, '[[![]]]', [], 'BrainF**k'],
    ['Ship-shipping ship, shipping shipping ships',
        'How many ships could a ship-shipping ship ship if a ship-shipping ship could ship ships?',
        'A ship-shipping ship would ship as many ships as a ship-shipping ship could ship if a ship-shipping ship could ship ships.'],
    ['overgloominess', 'synaxaria', 'illegibly', 'psychometrically']
];

doUselessThings();
doUselessThings.apply({name: 'nothing'}, []);

uselessData.forEach(function (line) {
    doUselessThings.apply(null, line);
});

doUselessThings.call({name: 'bigNothing'});
doUselessThings.call(null, 42, 'TheAnswer', 'The END', function(){return 42;});

/* Well, this is a stupid thing and I won't write shits about scopes.
   A good example with scopes is forEach vs. for loops
   (never-ever use for-loops if you can change it to .forEach!)
   This is well described by Vlado at the beginning of the second lecture. */