/* var zeroTest2 = [3, 'SoftUni – practical', 'software development', 'training + job!'];
   var zeroTest2 = [4, '374687697641', '%^^&%&^&#^$&%&*', '9997557.,.,.,', '%^6^44^&*$_+_'];
   var zeroTest3 = [10, 'The Software', 'University (SoftUni)', 'provides quality',
    'practical education,', 'profession and a job', 'for thousands young',
    'people who become', 'skillful software', 'engineers.', ' -- Nakov, July 2014'];

console.log(solve(zeroTest3)); */

function solve(args) {
    'use strict';
    var letters = 0, symbols = 0, numbers = 0,
        alphabet = 'abcdefghijklmnopqrstuvwxyz'.split(''),
        digits = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

    args.slice(1).forEach(function (line) {
        line.split('').forEach(function (ch) {
            ch = ch.toLowerCase().replace(' ', '')
				 .replace(/(\r\n|\n|\r)/gm,'')
				 .replace(/\s+/g,'');

            if (alphabet.indexOf(ch) >= 0) {
                letters += (alphabet.indexOf(ch) + 1) * 10;
            } else if (digits.indexOf(parseInt(ch)) >= 0) {
                numbers += parseInt(ch) * 20;
            } else if (!ch) {
                symbols += 0;
            } else {
                symbols += 200;
            }
        });
    });

    return letters + '\n' + numbers + '\n' + symbols;
}

