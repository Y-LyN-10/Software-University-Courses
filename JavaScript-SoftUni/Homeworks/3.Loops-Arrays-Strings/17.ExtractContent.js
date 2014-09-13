(function () {
    'use strict';

    function extractContent(input) {
        var field, cleared;

        field = document.getElementById('field');
        field.innerHTML = input;

        cleared = field.innerText.replace(/\s/g, '');
        return cleared;
    }

    var exampleInput = "<p>Hello</p><a href='http://w3c.org'>W3C</a>";
    console.log(extractContent(exampleInput));
}());