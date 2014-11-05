(function () {
    'use strict';

    var selectedShape = selectedShape || 'point';

    var canvas = document.getElementById("drawTriangle");
    var ctx = canvas.getContext("2d");

    var // Forms
        lineForm = document.querySelector('.line'),
        circleForm = document.querySelector('.circle'),
        triangleForm = document.querySelector('.triangle'),
        baseForm = document.getElementById('base-options'),
        rectangleForm = document.querySelector('.rectangle'),
        allOptions = document.getElementsByClassName('options'),
        controlCanvas = document.getElementById('control-canvas');

    // Hide all forms, except the base one
    function hideForms(){
        [].forEach.call(allOptions, function (form) {
            if(form.id !== 'base-options'){
                form.style.display = 'none';
            }
        });
    }

    hideForms();

    var // Buttons
        lineBtn = document.getElementById('draw-line'),
        pointBtn = document.getElementById('draw-point'),
        circleBtn = document.getElementById('draw-circle'),
        triangleBtn = document.getElementById('draw-triangle'),
        rectangleBtn = document.getElementById('draw-rectangle');

    var // Icon Buttons
        up = document.getElementById('up-btn'),
        down = document.getElementById('down-btn'),
        remove = document.getElementById('document');

    // Button Events
    pointBtn.addEventListener('click', function () {
        hideForms();
        selectedShape = 'point';
    });

    lineBtn.addEventListener('click', function () {
        hideForms();
        selectedShape = 'line';
        lineForm.style.display = 'block';
    });

    circleBtn.addEventListener('click', function () {
        hideForms();
        selectedShape = 'circle';
        circleForm.style.display = 'block';
    });

    triangleBtn.addEventListener('click', function () {
        hideForms();
        selectedShape = 'triangle';
        triangleForm.style.display = 'block';
    });

    rectangleBtn.addEventListener('click', function () {
        hideForms();
        selectedShape = 'line';
        rectangleForm.style.display = 'block';
    });

    // Input Event Handlers
    // TODO: ... object as... object

    // Get colors
    var defaultColor = '#000000';

    var colorFillSelector = document.getElementById("fill-color");
    colorFillSelector.addEventListener('change', function () {
        var fillColor = colorFillSelector.value;
    });
    var fillColor = colorFillSelector.value || defaultColor;

    var colorStrokeSelector = document.getElementById("stroke-color");
    colorStrokeSelector.addEventListener('change', function () {
        var strokeColor = colorStrokeSelector.value;
    });
    var strokeColor = colorStrokeSelector.value || defaultColor;


}());