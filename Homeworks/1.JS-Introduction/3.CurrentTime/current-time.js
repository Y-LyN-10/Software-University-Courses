'use strict';

var currentDateTime = new Date();

var hours = currentDateTime.getHours();
var minutes = currentDateTime.getMinutes();

if (minutes < 10) {
    minutes = '0' + minutes;
}

var currentTime = hours + ":" + minutes;
console.log(currentTime);