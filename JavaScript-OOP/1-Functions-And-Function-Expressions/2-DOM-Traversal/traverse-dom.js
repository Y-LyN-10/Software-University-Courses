/* Problem 2. DOM Traversal
 You are given an HTML file. Write a function that traverses all child elements
 of an element by a given CSS selector and prints all found elements in the format:
 <Element name>: id="<id>", class="<class>"
 Print each element on a new line. Indent child elements. */

function traverse(selector) {
    var element = document.querySelector(selector);

    function traverseElement(element, spacing) {
        var len, child, elementAsString;
        spacing = spacing || "    ";

        elementAsString = spacing + element.nodeName.toLowerCase() + ':';

        if(element.hasAttribute('class') || element.hasAttribute('id')) {
            if (element.id) {
                elementAsString += ' id="' + element.id;
            }
            if (element.classList.length > 0) {
                elementAsString += ' class="' + element.className + '"';
            }
        }

        console.log(elementAsString);

        [].forEach.call(element.childNodes, function (child) {
            if (child.nodeType === 1) {
                traverseElement(child, spacing + "    ");
            }
        });
    }

    traverseElement(element, '');
}

var selector = ".birds";
traverse(selector);