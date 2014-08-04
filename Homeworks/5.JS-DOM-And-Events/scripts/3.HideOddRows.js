(function () {
    var hideShowButton, rows;

    hideShowButton = document.getElementById('btnOddRows');
    hideShowButton.addEventListener('click', function () {
        rows = document.querySelectorAll('tr');

        if (hideShowButton.innerHTML === 'Hide Odd Rows') {
            hideRow(0);
            hideRow(2);
            hideRow(4);

            hideShowButton.classList.remove('btn-success');
            hideShowButton.classList.add('btn-danger');
            hideShowButton.innerHTML = 'Show Odd Rows';

        } else {
            showRow(0);
            showRow(2);
            showRow(4);

            hideShowButton.classList.remove('btn-danger');
            hideShowButton.classList.add('btn-success');
            hideShowButton.innerHTML = 'Hide Odd Rows';
        }
    }, false);

    function hideRow(i) {
        rows[i].className = 'hidden';
    }

    function showRow(j) {
        rows[j].className = 'visible';
    }
})();