'use strict';

// Example arrays to tests tasks 2, 7, 8 and 9 + Randoms
var exampleArrayWithNumbers = [
    // Examples from task 2. Min and Max Sum
    [1, 2, 1, 15, 20, 5, 7, 31],
    [2, 2, 2, 2, 2],
    [500, 1, -23, 0, -300, 28, 35, 12],

    // 8 Random Numbers to 100
    chance.rpg('8d100'),

    // Examples from task 7. Maximal Increasing Sequence
    [3, 2, 3, 4, 2, 2, 4],
    [3, 5, 4, 6, 1, 2, 3, 6, 10, 32],
    [3, 2, 1],

    // Examples from task 8. Sort Array
    [5, 4, 3, 2, 1],
    [12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3],

    // Examples from task 9. Most Frequent Number
    [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    [2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1],
    [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]
];

// Examples from task 5. Compare Chars
var exampleCharArray = [
    ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
    ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
    ['3', '5', 'g', 'd'],
    ['5', '3', 'g', 'd'],
    ['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
    ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']
];

// Examples from task 6. Maximal Sequence + Additional
var mixedArray = [
    [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    ['happy'],
    [2, 'qwe', 'qwe', 3, 3, '3'],
    [5, 4, 3, 3, '3', 3, 'test', 'test', 'test', 0, '0', '0', 0]
];

// Examples from task 10. Reverse String and 15. Most Frequent Word + Randoms
var exampleStrings = [
    'sample', 'softUni', 'java script',
    chance.word({length: 15}), chance.word(),
    chance.sentence({words: 5}), chance.syllable(),
    'in the middle of the night',
    'Welcome to SoftUni. Welcome to Java. Welcome everyone.',
    'Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'
];

// Examples from task 11. Check the Brackets
var exampleStringsWithBrackets = [
    '( ( a + b ) / 5 – d )',
    ') ( a + b ) )',
    '( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'
];

// Example arrays to tests tasks 12 and 13 + Randoms
var exampleArraysWithText = [
    // Examples from task 12. Substring Count and 13. Replace the White-Spaces
    ['in', 'We are living in a yellow submarine. We don\'t have anything else. ' +
        'Inside the submarine is very tight. So we are drinking all the day. ' +
        'We will move out of it in 5 days.'],
    ['your', 'No one heard a single word you said. They should have seen ' +
        'it in your eyes. What was going around your head.'],
    ['but', 'But you were living in another world tryin\' to get your message through.'],
    [chance.character(), chance.paragraph()],
];

var cards = [
    '8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦',
    'J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠',
    '10♣ 10♥'
];

var htmlCodes = [
    "<p>Hello</p><a href='http://w3c.org'>W3C</a>",
    "<ul>\n<li>\n<a href=http://softuni.bg>SoftUni</a>\n</li>\n</ul>",
    "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. " +
    "We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else."
];

