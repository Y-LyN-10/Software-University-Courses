(function () {
    function solve(args) {
        var star1 = args[0].split(' '), star1centerX = parseFloat(star1[1]), star1centerY = parseFloat(star1[2]),
            star2 = args[1].split(' '), star2centerX = parseFloat(star2[1]), star2centerY = parseFloat(star2[2]),
            star3 = args[2].split(' '), star3centerX = parseFloat(star3[1]), star3centerY = parseFloat(star3[2]),
            initXY = args[3].split(' '),
            numberOfMoves = parseInt(args[4]);

        var currentX = parseFloat(initXY[0]),
            currentY = parseFloat(initXY[1]);

        var matrix = [];
        for (var m = 0; m < numberOfMoves+1; m += 1) {
            var j = parseFloat(currentY);
            var i = parseFloat(currentX);

            if( i >= star3centerX - 1 && i <= star3centerX + 1 &&
                j >= star3centerY - 1 && j <= star3centerY + 1) {
                console.log(star3[0].toLowerCase());
            } else if (
                i >= star1centerX - 1 && i <= star1centerX + 1 &&
                j >= star1centerY - 1 && j <= star1centerY + 1) {
                console.log(star1[0].toLowerCase());
            } else if(
                i >= star2centerX - 1 && i <= star2centerX + 1 &&
                j >= star2centerY - 1 && j <= star2centerY + 1) {
                console.log(star2[0].toLowerCase());
            } else {
                console.log('space');
            }
            currentY++;
        }
    }

    var test1 = [
        'Sirius 3 7',
        'Alpha-Centauri 7 5',
        'Gamma-Cygni 10 10',
        '8 1',
        '6'
    ];

    var test2 = [
      'Terra-Nova 16 2',
        'Perseus 2.6 4.8',
        'Virgo 1.6 7',
        '2 5',
        '4'
    ];

    solve(test2);
}());