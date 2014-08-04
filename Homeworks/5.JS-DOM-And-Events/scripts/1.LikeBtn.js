(function () {
    var likeButton = document.getElementById('like-btn');

    likeButton.addEventListener('click', function () {
        if (likeButton.value === 'Like Me!') {
            likeButton.classList.add('btn-success');
            likeButton.value = 'Thanks';
        } else {
            likeButton.classList.remove('btn-success');
            likeButton.classList.remove('btn-danger');
            likeButton.value = 'Like Me!';
        }
    });

    likeButton.addEventListener('mouseover', function () {
        if (likeButton.value === 'Like Me!') {
            likeButton.classList.add('btn-success');
            likeButton.value = 'Like Me!';
        } else {
            likeButton.classList.remove('btn-success');
            likeButton.classList.add('btn-danger');
            likeButton.value = 'Unlike';
        }
    }, false);

    likeButton.addEventListener('mouseout', function () {
        if (likeButton.value === 'Like Me!') {
            likeButton.classList.remove('btn-danger');
            likeButton.classList.remove('btn-success');
            likeButton.value = 'Like Me!';
        } else {
            likeButton.classList.remove('btn-danger');
            likeButton.classList.add('btn-success');
            likeButton.value = 'Thanks';
        }
    }, false);
})();