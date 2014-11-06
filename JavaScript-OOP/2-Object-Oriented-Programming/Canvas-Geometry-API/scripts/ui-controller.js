(function () {
    'use strict';

    var selectedShape = selectedShape || 'point';

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
        rectangleBtn = document.getElementById('draw-rectangle'),
        addShape = document.getElementById('add-shape-btn');

    var // Icon Buttons
        up = document.getElementById('up-btn'),
        down = document.getElementById('down-btn'),
        remove = document.getElementById('document');

    var shapeProperties = document.getElementById('options-container');

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
        selectedShape = 'rectangle';
        rectangleForm.style.display = 'block';
    });

    function addShapeToTextBox(shape){
        var dataString = '';
        for(var key in shape){
            dataString += key + ': ' + value + ' ';
        }
        shapeProperties.innerText = shapeProperties.innerText + dataString;
    }

    addShape.addEventListener('click', function () {
        if(selectedShape === 'point'){
            var point = new Shape.Point(x, y, strokeColor, fillColor);
            addShapeToTextBox(point);
        } else if(selectedShape === 'triangle') {
            var triangle = new Shape.Triangle(x, y, strokeColor, fillColor, x2, y2, x3, y3);
        } else if(selectedShape === 'rectangle') {
            var rectangle = new Shape.Rectangle(x, y, strokeColor, fillColor, width, height);
        } else if(selectedShape === 'line') {
            var line = new Shape.Segment(x, y, strokeColor, fillColor, x1, y1);
        } else if(selectedShape === 'circle'){
            var circle = new Shape.Circle(x, y, strokeColor, fillColor, radius);
        } else {
            throw "Unknown or not implemented shape";
        }
    });

    /* - - - Get Shape Options - - - */

    var x, y, x1, y1, x2, y2, x3, y3;
    var width, height, radius;
    var defaultColor = '#000000';

    var colorFillSelector = document.getElementById("fill-color");
    var colorStrokeSelector = document.getElementById("stroke-color");

    var xInput = document.getElementById('x');
    var yInput = document.getElementById('y');

    var x1Input = document.getElementById('x1');
    var y1Input = document.getElementById('y1');

    var x2Input = document.getElementById('x2');
    var y2Input = document.getElementById('y2');

    var x3Input = document.getElementById('x3');
    var y3Input = document.getElementById('y3');

    var rectWidth = document.getElementById('rect-width');
    var rectHeight = document.getElementById('rect-height');

    var circleRadius = document.getElementById('circle-radius');

    // Options events on change

    colorFillSelector.addEventListener('change', function () {
        fillColor = colorFillSelector.value;
    });
    colorStrokeSelector.addEventListener('change', function () {
        strokeColor = colorStrokeSelector.value;
    });
    var fillColor = colorFillSelector.value || defaultColor;
    var strokeColor = colorStrokeSelector.value || defaultColor;

    xInput.addEventListener('change', function () {
        x = xInput.value;
    });
    yInput.addEventListener('change', function () {
        y = yInput.value;
    });

    x1Input.addEventListener('change', function () {
        x1 = x1Input.value;
    });
    y1Input.addEventListener('change', function () {
        y1 = y1Input.value;
    });

    x2Input.addEventListener('change', function () {
        x2 = x2Input.value;
    });
    y2Input.addEventListener('change', function () {
        y2 = y2Input.value;
    });

    x3Input.addEventListener('change', function () {
        x3 = x3Input.value;
    });
    y3Input.addEventListener('change', function () {
        y3 = y3Input.value;
    });

    rectWidth.addEventListener('change', function () {
        width = rectWidth.value;
    });
    rectHeight.addEventListener('change', function () {
        height = rectHeight.value;
    });

    circleRadius.addEventListener('change', function () {
        radius = circleRadius.value;
    });

}());