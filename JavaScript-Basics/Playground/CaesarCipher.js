(function () {
    'use strict';

    var zeroTest, zeroTest2, encodedMessage;

    function decodeCaesar(word, subKey) {
        var encoded = '',
            alphabet = [],
            index,
            nextIndex;

        alphabet = 'abcdefghijklmnopqrstuvwxyz'.split('');
        word.split('').forEach(function (ch) {
            index = alphabet.indexOf(ch);
            nextIndex = (index + subKey) % 26;

            if(alphabet.indexOf(ch) < 0){
                encoded += ' ';
            } else {
                encoded += alphabet[nextIndex];
            }
        });

        return encoded;
    }

    zeroTest = ['mxolxv fdhvdu', 23];
    zeroTest2 = ['rfgq gq y qcapcr ambc', 2];

    var firsTest = {
        'Code' : zeroTest[0],
        'Encoded' : decodeCaesar(zeroTest[0], zeroTest[1])
    };

    var secondTest = {
        'Code' : zeroTest2[0],
        'Encoded' : decodeCaesar(zeroTest2[0], zeroTest2[1])
    };

    console.log(firsTest);
    console.log(secondTest);

}());