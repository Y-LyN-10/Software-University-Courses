window.onload = function () {
    'use strict';

    var GAME_FIELD_SQUARES_COUNT = 9;

    var painted = [],
        content = [],
        winningCombinations = [
            [0, 1, 2],
            [3, 4, 5],
            [6, 7, 8],
            [0, 3, 6],
            [1, 4, 7],
            [2, 5, 8],
            [0, 4, 8],
            [2, 4, 6]
        ],
        turn = 0,
        squaresFilled = 0,
        targetID,
        i;

    for (i = 0; i < GAME_FIELD_SQUARES_COUNT; i += 1) {
        painted[i] = false;
        content[i] = '';
    }

    function canvasClicked(targetID) {
        var canvas = document.getElementById(targetID),
            cxt = canvas.getContext("2d"),
            img = new Image(),
            canvasNumber = targetID;

        function drawOnSand(symbol) {
            img.onload = function () {
                cxt.drawImage(img, 0, 0, 220, 150);
            };

            img.src = './imgs/' + symbol + '.png';
        }

        if (painted[canvasNumber - 1] === false) {
            if (turn % 2 === 0) {
                drawOnSand('x');
                content[canvasNumber - 1] = 'X';
            } else {
                drawOnSand('o');
                content[canvasNumber - 1] = 'O';
            }

            turn++;
            painted[canvasNumber - 1] = true;
            squaresFilled++;
            checkForWinners(content[canvasNumber - 1]);

            if (squaresFilled === GAME_FIELD_SQUARES_COUNT) {
                alert("You can't beat yourself? You should be very smart :}");
                window.location.reload(true);
            }
        } else {
            alert("That space is already occupied.");
        }
    }

    function checkForWinners(symbol) {
        winningCombinations.forEach(function(combination){
            if (content[combination[0]] === symbol &&
                content[combination[1]] === symbol &&
                content[combination[2]] === symbol) {
                alert(symbol + " won!");
                window.location.reload(true);
            }
        });
    }

    [].slice.call(document.querySelectorAll("canvas")).forEach(function(field){
        field.addEventListener('click', function (event) {
            targetID = event.target.id;
            canvasClicked(targetID);
        });
    });
};

/* Additional ideas what TODO (ever-never):
 - Animations:
    - drawing lines as animation
    - drawing symbols with sprites
    - 'clear' the game with a sea wave animation (carefully with the wet sand reproduction)
    - add scores and counters maybe (it's not so interesting thing)
    - add animations for footsteps in the sand and other surprises :D
    - well, enough xD
*/