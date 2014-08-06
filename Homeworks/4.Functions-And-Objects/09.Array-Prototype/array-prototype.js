(function () {
    'use strict';

    Array.prototype.removeItem = function (item) {
        var i;
        for (i = 0; i < this.length; i += 1) {
            if (this[i] === item) {
                this.splice(i, 1);
                i -= 1; // Because if the items are repeating, they've got skipped
            }
        }
    };

    var exampleArray = [
        [1, [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1']],
        ['bye', ['hi', 'bye', 'hello' ]],
        ['Yabaaa', ['Ya', 'ba', 'aa', 'Yabaa', 'yaBaaa']],
        [0, [0, 0, 0, 0, 0, 0, '0']]
    ];

    exampleArray.forEach(function (array) {
        array[1].removeItem(array[0]);
        console.log(array[1]);
    });
}());
