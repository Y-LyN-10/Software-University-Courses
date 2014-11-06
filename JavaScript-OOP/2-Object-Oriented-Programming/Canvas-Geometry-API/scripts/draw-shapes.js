'use strict';

var Shape = shapeModule;

var canvas = document.getElementById("drawArea");
var ctx = canvas.getContext("2d");

function drawPoint(p) {
    ctx.fillStyle = p._fillColor;
    ctx.strokeStyle = p._strokeColor;
    ctx.beginPath();
    ctx.moveTo(p._x, p._y);
    ctx.arc(p._x, p._y, 1, 0, 360, false);
    ctx.closePath();
    ctx.stroke();
    ctx.fill();
}

function drawTriangle(t) {
    ctx.fillStyle = t._fillColor;
    ctx.strokeStyle = t._strokeColor;
    ctx.beginPath();
    ctx.moveTo(t._x, t._y);
    ctx.lineTo(t._x2, t._y2);
    ctx.stroke();
    ctx.lineTo(t._x3, t._y3);
    ctx.stroke();
    ctx.fill();
    ctx.closePath();
}

function drawRectangle(r) {
    ctx.fillStyle = r._fillColor;
    ctx.strokeStyle = r._strokeColor;
    ctx.beginPath();
    ctx.moveTo(r._x, r._y);
    ctx.fillRect(r._x, r._y, r._width, r._height);
    ctx.strokeRect(r._x, r._y, r._width, r._height);
    ctx.fill();
    ctx.stroke();
}

function drawLine(l){
    ctx.fillStyle = l._fillColor;
    ctx.strokeStyle = l._strokeColor;
    ctx.beginPath();
    ctx.moveTo(l._x, l._y);
    ctx.lineTo(l._x2, l._y2);
    ctx.stroke();
    ctx.fill();
}

function drawCircle(c){
    ctx.fillStyle = c._fillColor;
    ctx.strokeStyle = c._strokeColor;
    ctx.beginPath();
    ctx.moveTo(c._x, x._y);
    ctx.arc(c._x, c._y, c._radius, 0, 360, false);
    ctx.closePath();
    ctx.fill();
    ctx.stroke();
}