var shapeModule = (function () {
    'use strict';

    function Shape(x, y, strokeColor, fillColor) {
        this._x = x;
        this._y = y;
        this._strokeColor = strokeColor;
        this._fillColor = fillColor;
    }

    function Point(x, y, strokeColor, fillColor) {
        Shape.call(this, x, y, strokeColor, fillColor);
    }

    function Circle(x, y, strokeColor, fillColor, radius) {
        Shape.call(this, x, y, strokeColor, fillColor);
        this._radius = radius;
    }

    function Rectangle(x, y, strokeColor, fillColor, width, height) {
        Shape.call(this, x, y, strokeColor, fillColor);
        this._width = width;
        this._height = height;
    }

    function Triangle(x, y, strokeColor, fillColor, x2, y2, x3, y3) {
        Shape.call(this, x, y, strokeColor, fillColor);
        this._x2 = x2;
        this._y2 = y2;
        this._x3 = x3;
        this._y3 = y3;
    }

    function Segment(x, y, strokeColor, fillColor, x2, y2) {
        Shape.call(this, x, y, strokeColor, fillColor);
        this._x2 = x2;
        this._y2 = y2;
    }

    Shape.Point = Point;
    Point.prototype = Object.create(Shape.prototype);
    Point.prototype.constructor = Point;

    Shape.Circle = Circle;
    Circle.prototype = Object.create(Shape.prototype);
    Circle.prototype.constructor = Circle;

    Shape.Rectangle = Rectangle;
    Rectangle.prototype = Object.create(Shape.prototype);
    Rectangle.prototype.constructor = Rectangle;

    Shape.Triangle = Triangle;
    Triangle.prototype = Object.create(Shape.prototype);
    Triangle.prototype.constructor = Triangle;

    Shape.Segment = Segment;
    Segment.prototype = Object.create(Shape.prototype);
    Segment.prototype.constructor = Segment;

    return Shape;
}());




