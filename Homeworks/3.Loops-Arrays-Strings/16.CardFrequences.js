/*  Problem 16.	Cards Frequencies
 Write a JavaScript function findCardFrequency(value) that that accepts the
 following parameters: array of several cards (face + suit), separated by a
 space. The function calculates and prints at the console the frequency of
 each card face in format "card_face -> frequency". The frequency is calculated
 by the formula appearances / N and is expressed in percentages with exactly 2
 digits after the decimal point. The card faces with their frequency should be
 printed in the order of the card face's first appearance in the input. The same
 card can appear multiple times in the input, but its face should be listed only
 once in the output. Write JS program cardFrequencies.js that invokes your function
 with the sample input data below and prints the output at the console.  */
(function () {
    'use strict';

    var cardStringsExamples, frequency;

    function findCardFrequency(cardsString) {
        var cards, cardsLength, card,
            maxCounter = 1, percent,
            frequencies = [],
            stringedResult = [];

        cards = cardsString
            .split(/[♣♦♥♠ ]+/)
            .filter(Boolean); //remove ghosts ^^

        cardsLength = cards.length;

        cards.forEach(function (card) {
            if (frequencies[card] === undefined) {
                frequencies[card] = { word: card, times: 1 };
            } else {
                frequencies[card].times += 1;
            }

            if (frequencies[card].times > maxCounter) {
                maxCounter = frequencies[card].times;
            }
        });

        for (var i in frequencies) {
            card = frequencies[i];
            percent = ((card.times * 100) / cardsLength).toFixed(2);
            stringedResult.push(i + " -> " + percent + "%");
        }

        return stringedResult.join('\n');
    }

    cardStringsExamples = [
        '8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦',
        'J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠',
        '10♣ 10♥'
    ];

    cardStringsExamples.forEach(function (cardsString) {
        frequency = findCardFrequency(cardsString);
        console.log(frequency + '\n');
    });
}());