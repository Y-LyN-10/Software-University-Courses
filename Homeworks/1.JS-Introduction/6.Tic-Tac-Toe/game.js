var canvas = document.getElementById('gameCanvas');
var context = canvas.getContext('2d');
var imageObj = new Image();

imageObj.onload = function() {
    context.drawImage(imageObj, 69, 50);
};

imageObj.src = 'http://www.html5canvastutorials.com/demos/assets/darth-vader.jpg';

var anim = new Kinetic.Animation(function(frame) {
    var time = frame.time,
    timeDiff = frame.timeDiff,
    frameRate = frame.frameRate;

    // update stuff
    }, layer);

anim.start();