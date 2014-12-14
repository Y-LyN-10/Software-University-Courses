var app = app || {};

(function () {
    'use strict';

    var baseUrl = 'https://api.parse.com/1/';
    var ajaxRequester = app.ajaxRequester.get();
    var data = app.data.get(baseUrl, ajaxRequester);
    var controller = app.controller.get(data);
    controller.attachEventHandlers();

    function isAuthorized(){
        return controller.authorizationCheck();
    }

    if (isAuthorized()) {
        controller.loadUserMenu();
    } else {
        $('#user-nav').hide();
    }

    app.router = Sammy(function () {
        var selector = '#main';
        this.get('#/', function () {
            if (isAuthorized()) {
                controller.loadUserMenu();
            } else {
                $('#user-nav').hide();
            }

            controller.loadHome(selector);
        });

        this.get('#/login', function () {
            if (isAuthorized()) {
                this.redirect('#/logout');
            }
            controller.loadLogin(selector);
        });

        this.get('#/register', function () {
            if (isAuthorized()) {
                this.redirect('#/logout');
            }
            controller.loadRegister(selector);
        });

        this.get('#/products', function () {
            if (isAuthorized()) {
                controller.loadProducts(selector);
            } else {
                this.redirect('#/');
            }
        });

        this.get('#/products/add', function () {
            if (isAuthorized()) {
                controller.loadAddProduct(selector);
            } else {
                this.redirect('#/');
            }
        });

        this.get('#/products/edit/:id', function () {
            if (isAuthorized()) {
                controller.loadEditProduct(selector);
            } else {
                this.redirect('#/');
            }
        });

        this.get('#/products/delete/:id', function () {
            if (isAuthorized()) {
                controller.loadDeleteProduct(selector, this.params['id']);
            } else {
                this.redirect('#/');
            }
        });

        this.get('#/logout', function () {
            controller.logout();
            this.redirect('#/');
        });
    });

    app.router.run('#/');
}());