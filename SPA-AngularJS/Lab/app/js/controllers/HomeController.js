'use strict';

app.controller('HomeController',
    function ($scope, adsService, notifyService) {
        adsService.getAds(
            null,
            function success(data) {
                $scope.ads = data;
            },
            function error(err) {
                notifyService.showError("Cannot load ads", err);
            }
        );
    }
);
