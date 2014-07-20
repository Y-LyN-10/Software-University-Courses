'use strict';

//Global Variables
var painted;
var content;
var winningCombinations;
var turn = 0;
var squaresFilled = 0;
var img;

//Instanciate Arrays
window.onload = function () {
    painted = [];
    content = [];
    winningCombinations = [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6]
    ];

    var l;
    for (l = 0; l <= 8; l+=1) {
        painted[l] = false;
        content[l] = '';
    }
}

//Game methods
function canvasClicked(canvasNumber) {
    var theCanvas = "canvas" + canvasNumber;
    var c = document.getElementById(theCanvas);
    var cxt = c.getContext("2d");
    img = new Image();

    function drawOnSand(symbol) {
        img.onload = function() {
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

        if (squaresFilled === 9) {
            alert("You can't beat yourself? You should be very smart :}");
            location.reload(true);
        }
    } else {
        alert("That space is already occupied.");
    }
}

function checkForWinners(symbol) {
    var a;
    for (a = 0; a < winningCombinations.length; a+=1) {
        if (content[winningCombinations[a][0]] === symbol
            && content[winningCombinations[a][1]] === symbol
            && content[winningCombinations[a][2]] === symbol) {
            alert(symbol + " won!");
            location.reload(true);
        }
    }
}

/* Additional ideas what TODO (ever-never):
-Animations:
    - drawing lines as animation
    - drawing symbols with sprites
    - 'clear' the game with a sea wave animation (carefully with the wet sand reproduction)
    - add scores and counters maybe (it's not so interesting thing)
    - add animations for footsteps in the sand and other surprizes :D
    - well, enough xD
*/