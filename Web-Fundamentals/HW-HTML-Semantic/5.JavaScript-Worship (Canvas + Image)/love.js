window.onload = function(){

    var canvas = document.getElementById("Canvas");
    canvas.width = 240;
    canvas.height = 260;

    var ctx = canvas.getContext("2d");

    //"I love JavaScript"
    ctx.beginPath();
    ctx.fillStyle = "black";
    ctx.font = "30px Tahoma";
    ctx.fillText("I love JavaScript", 10, 50);
    ctx.stroke();

    //Yellow Rectangle
    ctx.beginPath();
    ctx.fillStyle = "rgb(241, 218, 78)";
    ctx.fillRect(50, 80, 134, 134);
    ctx.stroke();

    //JS
    var jsText = new Image();
    jsText.src = 'JS.png';
    ctx.drawImage(jsText, 78, 135);
    ctx.update();
}