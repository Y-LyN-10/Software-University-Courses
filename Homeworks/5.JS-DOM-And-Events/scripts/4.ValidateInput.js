(function () {
    var inputBlock, field, inputValue, correctValue;

    inputBlock = document.getElementById('input-block');
    field = document.getElementById('onlyNumbers');

    field.addEventListener('input', function (event) {
        inputValue = field.value;

        if (isNaN(inputValue)) {
            inputBlock.classList.add('has-error');
            field.disabled = true;
            correctValue = field.value;
            correctValue = correctValue.slice(0, (correctValue.length - 1));
            field.value = correctValue;
        }

        setTimeout(function () {
            inputBlock.classList.remove('has-error');
            field.disabled = false;
            field.focus()
        }, 500);
    });

    field.addEventListener('paste', function (event) {
        inputBlock.classList.add('has-error');
        field.disabled = true;
        field.value = correctValue || ''; //because of 'undefined' if there was nothing before

        setTimeout(function () {
            inputBlock.classList.remove('has-error');
            field.disabled = false;
            field.focus()
        }, 500);
    });
})();

//well, it has some bugs, but not that bad.