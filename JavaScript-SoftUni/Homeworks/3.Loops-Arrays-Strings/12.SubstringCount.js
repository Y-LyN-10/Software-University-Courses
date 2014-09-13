(function () {
    'use strict';

    var exampleArrayWithText, counted, result;

    function countSubstring(text) {
        var subString, string, regex, count;

        subString = text[0].toLowerCase();
        string = text[1].toLowerCase();

        // More about RegExp constructor you can read here:
        // http://stackoverflow.com/a/4371855
        regex = new RegExp(subString, 'g');
        count = string.match(regex);

        return count.length;
    }

    exampleArrayWithText = [
        ['in', 'We are living in a yellow submarine. We don\'t have anything else. ' +
            'Inside the submarine is very tight. So we are drinking all the day. ' +
            'We will move out of it in 5 days.'], // 9
        ['your', 'No one heard a single word you said. They should have seen ' +
            'it in your eyes. What was going around your head.'], // 2
        ['but', 'But you were living in another world tryin\' to get your message through.'] // 1
    ];

    exampleArrayWithText.forEach(function (text) {
        counted = countSubstring(text);
        console.log(counted);
    });
}());