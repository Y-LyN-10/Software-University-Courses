window.onload = function(){

    var canvas = document.getElementById("Canvas");
    canvas.width = 240;
    canvas.height = 260;

    var ctx = canvas.getContext("2d");

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
    ctx.beginPath();
    ctx.fillStyle = "black";
    ctx.fontFamily = "url()";
    ctx.font = "90px NeutraText-Bold";
    ctx.fontWeight = "bolder";
    ctx.fillText("JS", 83, 202);
    ctx.stroke();

}