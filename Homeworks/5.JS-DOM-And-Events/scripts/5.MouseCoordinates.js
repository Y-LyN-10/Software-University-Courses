(function () {
    window.onmousemove = handleMouseMove;
    function handleMouseMove(event) {
        document.getElementById('x').innerHTML = event.clientX;
        document.getElementById('y').innerHTML = event.clientY;

        var currentDate = new Date();
        document.getElementById('dateTime').innerHTML = currentDate;
    }
})();