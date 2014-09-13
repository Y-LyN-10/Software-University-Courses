// Well, this task was pretty strange and this is how I understood it.

(function () {
    var parentElement, divs, showHideBtn, resultList, li, isClickedOnce = false;

    parentElement = document.getElementById('problem-two');
    divs = parentElement.children; //.getElementsByTagName('div');

    showHideBtn = document.getElementById('btnInnerDivs');
    resultList = document.getElementById('result');

    showHideBtn.addEventListener('click', function (ev) {
        if (!isClickedOnce) {
            for (var i = 0; i < divs.length - 1; i++) {
                li = document.createElement('li');
                li.innerHTML = divs[i].innerHTML;
                resultList.appendChild(li);
            }
            isClickedOnce = true;
        }
    });
})();
