'use strict';

app.factory('authService',
    function ($http, baseServiceUrl) {
        return {
            login: function(userData, success, error) {
                // TODO
            },

            register: function(userData, success, error) {
                // TODO
            },

            logout: function() {
                // TODO
            },

            getCurrentUser : function() {
                // TODO
            },

            isAnonymous : function() {
                // TODO
            },

            isLoggedIn : function() {
                // TODO
            },

            isNormalUser : function() {
                // TODO
            },

            isAdmin : function() {
                // TODO
            },

            getAuthHeaders : function() {
                // TODO
            }
        }
    }
);
