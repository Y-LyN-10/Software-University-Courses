var shapeModule = (function () {
    'use strict';

    function Shape(x, y, color) {
        this._x = x;
        this._y = y;
        this._color = color;
    }

    function Point(x, y, color) {
        Shape.call(this, x, y, color);
    }

    function Circle(x, y, color, r) {
        Shape.call(this, x, y, color);
        this._r = r;
    }

    function Rectangle(x, y, color, width, height) {
        Shape.call(this, x, y, color);
        this._width = width;
        this._height = height;
    }

    function Triangle(x, y, color, x2, y2, x3, y3) {
        Shape.call(this, x, y, color);
        this._x2 = x2;
        this._y2 = y2;
        this._x3 = x3;
        this._y3 = y3;
    }

    function Segment(x, y, color, x2, y2) {
        Shape.call(this, x, y, color);
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




