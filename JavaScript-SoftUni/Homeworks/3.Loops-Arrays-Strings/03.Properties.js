/*  Problem 3. Properties
 Write a JavaScript function displayProperties(value) that displays all the properties
 of the "document" object in alphabetical order. Write a JS program docProperties.js that
 invokes your function with the sample input data below and prints the output at the console. */
(function () {
    function getProperties() {
        var properties = [];
        for (var prop in document) properties.push(prop);

        properties.sort();
        return properties;
    }

    // And display here...
    console.log(getProperties().join('\n'));
}());
