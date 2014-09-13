/*  Problem 1. Home Town
 Write a JavaScript code hometown.js that shows your hometown in a popup browser window (alert).
 Crate a HTML page hometown.html that executes your JavaScript code. */

var is_chrome = navigator.userAgent.toLowerCase().indexOf('chrome') > -1;
if (!is_chrome) {
    var is_safari = navigator.userAgent.toLowerCase().indexOf('safari') > -1;
    //somehow, GeoLocation script doesn't work on my Aurora Browser, so I decided just to add this stupid check.
    alert("Plovdiv");
    alert("Just kidding. It's okay for the homework task, but if you want to see some magic, use Chrome. Or Safari");
} else {
    var geocoder;

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(successFunction, errorFunction);
    }

    //Get the latitude and the longitude;
    function successFunction(position) {
        var lat = position.coords.latitude;
        var lng = position.coords.longitude;

        var latlon = position.coords.latitude + "," + position.coords.longitude;

        var img_url = "http://maps.googleapis.com/maps/api/staticmap?center="
            + latlon + "&zoom=14&size=400x300&sensor=false";

        document.getElementById("mapHolder").innerHTML = "<img src='" + img_url + "'>";
        codeLatLng(lat, lng);
    }

    function errorFunction() {
        alert("You don't want to share your location with yourself? Strange... well, I'll tell you where I'm from. It's Neverlandia!");
    }

    function initialize() {
        geocoder = new google.maps.Geocoder();
    }

    function codeLatLng(lat, lng) {
        var latlng = new google.maps.LatLng(lat, lng);
        geocoder.geocode({'latLng': latlng}, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                console.log(results);
                if (results[1]) {
                    //formatted address
                    alert("Maybe it's not your hometown, but now you are at: " + results[4].formatted_address);
                    alert("And to be more correct, your current location is: " + results[1].formatted_address + " : ) ");
                    alert("And in case, you've forgot your address, it's: " + results[0].formatted_address);
                } else {
                    alert("Ooh, Geocoder doesn't work. Don't mind it.");
                }
            } else {
                alert("Geocoder failed due to: " + status);
            }
        });
    }
}