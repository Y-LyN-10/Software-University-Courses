(function() {
    window.onmousemove = handleMouseMove;
    function handleMouseMove(event) {
        event = event || window.event; // IE-ism
        document.getElementById('x').innerHTML = event.clientX;
        document.getElementById('y').innerHTML = event.clientY;
    }
})();