window.onload = function(){
    var likeButton = document.getElementById('like-btn');

    likeButton.addEventListener( 'click' , function () {
        if ( likeButton.classList.contains('btn-success')){
            likeButton.classList.remove('btn-success');
            likeButton.classList.add('btn-danger');
            likeButton.value = 'Unlike';
        } else {
            likeButton.classList.remove('btn-danger');
            likeButton.classList.toggle('btn-success');
            likeButton.value = 'Like';
        }
    });
};
