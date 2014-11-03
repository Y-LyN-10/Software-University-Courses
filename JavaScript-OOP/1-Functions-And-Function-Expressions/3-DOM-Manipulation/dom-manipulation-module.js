/* Create an IIFE module for working with the DOM tree. The module should support the following operations:
 •	Adding а DOM element to a parent element specified by selector
 •	Removing a child element from a parent specified by selector
 •	Attaching an event to a given selector by given event type and event handler
 •	Retrieving elements by a given CSS selector
 The module should reveal only its methods (i.e. everything else should be encapsulated).*/

var domModule = (function () {
    'use strict';

    function getElement(selector) {
        return document.querySelector(selector);
    }

    function getElements(selector) {
       return document.querySelectorAll(selector);
    }

    function appendChildToParent(childToAppend, parentSelector) {
        var parent = getElement(parentSelector);

        if (!parent) {
            throw new Error("Can not append element to non existing parent.");
        }

        parent.appendChild(childToAppend);
    }

    function removeElement(parentSelector, childSelector) {
        var parent = getElement(parentSelector);
        var child = getElement(childSelector);

        if (!parent) {
            throw new Error("Can't remove child element from non existing parent.");
        }

        parent.removeChild(child);
    }

    function attachEvent(elementSelector, eventType, handler) {
        var elements = getElements(elementSelector);

        if (!elements) {
            throw new Error("Can't attach event to non existing element.");
        }

        [].forEach.call(elements, function (element) {
            console.log(element);
            element.addEventListener(eventType, handler);
        });
    }

    return {
        appendChild: appendChildToParent,
        removeChild: removeElement,
        addHandler: attachEvent,
        retrieveElements: getElements
    };
})();

/*** Sample Code, given in the task ***/

var liElement = document.createElement("li");

domModule.appendChild(liElement,".birds-list");
domModule.removeChild("ul.birds-list","li:first-child");
domModule.addHandler(".birds", 'click', function(){ alert("I'm a bird!") });

var elements = domModule.retrieveElements(".bird");
console.log(elements);