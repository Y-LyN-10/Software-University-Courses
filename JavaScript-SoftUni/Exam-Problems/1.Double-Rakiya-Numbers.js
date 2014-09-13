(function () {
    function solve(args) {
        var startNumber = Number(args[0]),
            endNumber = Number(args[1]),
            rakiyaNumbers = [], i, j, number,
            currentNumber, twoDigitsNumber,
            pattern, restOfTheString;

        // Add all "double Rakiya numbers" in array
        for (i = startNumber; i <= endNumber; i += 1) {
            currentNumber = i.toString();
            for (j = 0; j < currentNumber.length - 1; j += 1) {
                twoDigitsNumber = currentNumber[j] + '' + currentNumber[j + 1];
                pattern = new RegExp(twoDigitsNumber);
                restOfTheString = currentNumber.slice(j + 2).toString();

                if (Boolean(pattern.test(restOfTheString))) {
                    rakiyaNumbers.push(currentNumber);
                }
            }
        }

        // Print the result
        console.log('<ul>');
        for (number = startNumber; number <= endNumber; number += 1) {
            if (rakiyaNumbers.indexOf(number.toString()) > -1) {
                console.log('<li><span class=\'rakiya\'>' + number
                    + '</span><a href="view.php?id=' + number + '>View</a></li>');
            } else {
                console.log('<li><span class=\'num\'>' + number + '</span></li>');
            }
        }
        console.log('</ul>');
    }


    var zeroTest = ['5', '8'];
    var secondZeroTest = ['11210', '11215'];
    var thirdZeroTest = ['55555', '55560'];
    solve(thirdZeroTest);
}());