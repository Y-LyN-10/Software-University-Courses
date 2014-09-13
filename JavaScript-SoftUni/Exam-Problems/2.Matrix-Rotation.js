(function () {
    function solve(args) {
        var degrees = args[0].replace(/[\D+]/g, ''),
            linesInMatrix = args.slice(1),
            reversedLines = [], longestWord,
            matrix = [];

        // Find the longest word
        longestWord = linesInMatrix.reduce(function (a, b) {
            return a.length > b.length ? a : b;
        });

        // Add whitespaces
        matrix = linesInMatrix.map(function (line) {
            line = line.split('');
            for (var i = 0; i < longestWord.length; i++) {
                line[i] = line[i] || ' ';
            }
            return line.join('');
        });

        degrees = degrees % 360;
        switch (degrees.toString()){
            case '0': printMatrix(matrix); break;
            case '90': rotateBy90(matrix); break;
            case '180': rotateBy180(matrix); break;
            case '270': rotateBy270(matrix); break;
        }

        function printMatrix(matrix){
            console.log(matrix.join('\n'));
        }

        function rotateBy90(joinedMatrix) {
            var w = joinedMatrix.length;
            var h = longestWord.length;

            var matrix = [];
            matrix = joinedMatrix.map(function (line, i) {
                matrix[i] = [];
                matrix[i] = line.split('');
                return matrix[i];
            });

            var rotatedMatrix = [];

            for (var a = 0; a < h; ++a) {
                rotatedMatrix[a] = [];
                for (var b = 0; b < w; ++b) {
                    rotatedMatrix[a][b] = matrix[w - b - 1][a];
                }
                rotatedMatrix[a] = rotatedMatrix[a].join('');
            }

            console.log(rotatedMatrix.join('\n'));
        }

        function rotateBy180(matrix){
            matrix.forEach(function (line) {
                line = line.split('').reverse().join('');
                reversedLines.unshift(line);
            });
            console.log(reversedLines.join('\n'));
        }

        // Well, copy-paste solutions for 180 & 90 degrees
        function rotateBy270(matrix) {
            matrix.forEach(function (line) {
                line = line.split('').reverse().join('');
                reversedLines.unshift(line);
            });

            matrix = reversedLines;

            var w = matrix.length;
            var h = longestWord.length;

            var realMatrix = [];
            realMatrix = matrix.map(function (line, i) {
                matrix[i] = [];
                matrix[i] = line.split('');
                return matrix[i];
            });

            var rotatedMatrix = [];

            for (var a = 0; a < h; ++a) {
                rotatedMatrix[a] = [];
                for (var b = 0; b < w; ++b) {
                    rotatedMatrix[a][b] = realMatrix[w - b - 1][a];
                }
                rotatedMatrix[a] = rotatedMatrix[a].join('');
            }

            console.log(rotatedMatrix.join('\n'));

        }
    }

    var zeroTest = ['Rotate(90)', 'hello', 'softuni', 'exam'];
    var secondZeroTest = ['Rotate(180)', 'hello', 'softuni', 'exam'];
    var thirdZeroTest = ['Rotate(270)', 'hello', 'softuni', 'exam'];
    var fourthZeroTest = ['Rotate(720)', 'js', 'exam'];

    solve(thirdZeroTest);

}());