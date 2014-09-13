/*  Problem 8. Sort Array
 Sorting an array means to arrange its elements in increasing order.
 Write a JavaScript function sortArray(value) to sort an array. Use the
 "selection sort" algorithm: find the smallest element, move it at the first
 position, find the smallest from the rest, move it at the second position, etc.
 Write JS program arraySorter.js that invokes your function with the sample input
 data below and prints the output at the console. Use a second array. */
(function () {
    'use strict';

    var exampleArrays, sortedArray, result;

    /* Instead of comparing each array item to its neighbor, the goal in selection
     sort is to locate the smallest remaining value and drop it into the correct
     place in the array. The basic algorithm looks like this:

     1. Assume the first item is the smallest value.
     2. Compare this item to the second item.
     3. If the second item is smaller than the first, set the second item as the new minimum.
     4. Continue until the end of the data set is reached.
     5. If the minimum value is not the item you started with, swap them.

     More about it you can find here:
     http://www.nczonline.net/blog/2009/09/08/computer-science-in-javascript-selection-sort/

     */

    function selectionSort(items) {

        var len = items.length,
            min, i, j;

        for (i = 0; i < len; i += 1) {
            min = i; //set minimum to this position

            //check the rest of the array to see if anything is smaller
            for (j = i + 1; j < len; j += 1) {
                if (items[j] < items[min]) {
                    min = j;
                }
            }

            //if the minimum isn't in the position, swap it
            if (i != min) {
                swap(items, i, min);
            }
        }

        return items;
    }

    function swap(items, firstIndex, secondIndex) {
        var temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }

    exampleArrays = [
        [5, 4, 3, 2, 1],
        [12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]
    ];

    exampleArrays.forEach(function (array) {
        sortedArray = selectionSort(array);
        console.log(sortedArray.toString());
    })
}());