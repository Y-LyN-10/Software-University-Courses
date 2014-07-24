(function () {
    'use strict';

    function convertDigitToWord(digit){

      var digitsAsWords = [
          'Zero', 'One', 'Two', 'Three', 'Four',
          'Five', 'Six', 'Seven', 'Eight', 'Nine'
      ];

      return digitsAsWords[digit];
    }

    var randomDigit, word, result, i;
    for(i = 0; i < 5; i+=1){
        randomDigit= chance.integer({min: 0, max: 9});
        word = convertDigitToWord(randomDigit);
        result = {
            digit: randomDigit,
            asWord: word
        };

        console.log(result);
    }
}());