var app = app || {};

app.controller = (function(){
    'use strict';

    function BaseController(data){
        this._data = data;
    }

    BaseController.prototype.loadHome = function (selector) {
        $.get('templates/home.html', function (template) {
            var currentUser = localStorage;
            var output = Mustache.render(template, currentUser);
            $(selector).html(output);
        });
    };

    BaseController.prototype.loadLogin = function (selector) {
        $(selector).load('templates/login.html');
    };

    BaseController.prototype.logout = function () {
        this._data.users.logout();
        alert('You are kicked-off!');
        $('#user-nav').hide();
        $('#guest-nav').show();
    };

    BaseController.prototype.loadUserMenu = function () {
        $('#guest-nav').hide();
        $('#user-nav').show();
    };

    BaseController.prototype.loadRegister = function (selector) {
        $(selector).load('templates/register.html');
    };

    BaseController.prototype.loadProducts = function (selector) {
        this._data.products.getAll()
            .then(function (data) {
                $.get('templates/products.html', function (template) {
                    var output = Mustache.render(template, data);
                    $(selector).html(output);
                });
            });
    };

    BaseController.prototype.loadAddProduct = function (selector) {
        $(selector).load('templates/add-product.html');
    };

    BaseController.prototype.loadEditProduct = function (selector) {
        $(selector).load('templates/edit-product.html');
    };

    BaseController.prototype.loadDeleteProduct = function (selector, objectId) {
        this._data.products.getById(objectId)
            .then(function (data) {
                console.log(data);
                $.get('templates/delete-product.html', function (template) {
                    var output = Mustache.render(template, data);
                    $('#main').html(output);
                });
            });
    };

    BaseController.prototype.authorizationCheck = function () {
        return localStorage.length;
    };

    BaseController.prototype.attachEventHandlers = function () {
        var selector = '#main';

        attachLoginHandler.call(this, selector);
        attachRegisterHandler.call(this, selector);
        attachCreateProductHandler.call(this, selector);
        attachEditProductHandler.call(this, selector);
        attachDeleteProductHandler.call(this, selector);
        attachDeletePageProductHandler.call(this, selector);
    };

    var attachLoginHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#login-btn', function () {
            var username = $('#username').val();
            var password = $('#password').val();
            _this._data.users.login(username, password)
                .then(function (data) {
                    if(localStorage.length){
                        alert('Successfully logged in!');
                        window.history.replaceState('Login', 'Welcome', '#/');
                        window.location.reload();
                        $('#guest-nav').hide();
                        $('#user-nav').show();
                    } else {
                        console.log(error);
                    }
                }, function (error) {
                    alert('wrong username/password!');
                    console.log(error);
                });
        });
    };

    var attachRegisterHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#register-button', function () {
            var username = $('#username').val();
            var password = $('#password').val();
            var passwordAgain = $('#confirm-password').val();

            if(escapeHtml(username) !== username){
                alert('Invalid username! Please, don\'t act like a dumb user. I believe you\'re not!');
            } else{
                if(password === passwordAgain){
                    _this._data.users.register(username, password)
                        .then(function (data) {
                            alert('Registration was successfull!');
                            _this._data.users.login(username, password)
                                .then(function (data) {
                                    if(localStorage.length){
                                        window.history.replaceState('Register', 'Welcome', '#/');
                                        window.location.reload();
                                        $('#guest-nav').hide();
                                        $('#user-nav').show();
                                    } else {
                                        console.log(error);
                                    }
                                });
                        }, function (error) {
                            console.log(error);
                        });
                } else {
                    alert('passwords are not equal!');
                }
            }
        });
    };

    var attachCreateProductHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#add-product-button', function (ev) {
            var name = $('#name').val();
            var category = $('#category').val();
            var price = $('#price').val();

            var product = {
                name: name,
                category: category,
                price: Number(price)
            };

            _this._data.products.add(product)
                .then(function (data) {
                    _this._data.products.getById(data.objectId)
                        .then(function (product) {
                            $('#name').val('');
                            $('#category').val('');
                            $('#price').val('');
                            alert('Product is succesfully added!');
                            return product;
                        }, function (error) {
                            console.log(error);
                        });
                }, function (error) {
                    console.log(error);
                });
        });
    };

    var attachEditProductHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#add-product-button', function (ev) {
            var name = $('#name').val();
            var category = $('#category').val();
            var price = $('#price').val();

            var product = {
                name: name,
                category: category,
                price: Number(price)
            };

            _this._data.products.add(product)
                .then(function (data) {
                    _this._data.products.getById(data.objectId)
                        .then(function (product) {
                            $('#name').val('');
                            $('#category').val('');
                            $('#price').val('');

                            alert('Product is succesfully added!');
                            return product;
                        }, function (error) {
                            console.log(error);
                        });
                }, function (error) {
                    console.log(error);
                });
        });
    };

    var attachDeleteProductHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#delete-product-button', function (ev) {
            var url = window.location.hash;
            console.log(url);
            var id = url.substring(url.lastIndexOf('/') + 1);
            _this._data.products.delete(id);
            alert('deleted!');
        });
    };

    var attachDeletePageProductHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#delete-button', function (ev) {
            console.log('delete-button clicked on products page');
            var objectId = $(ev.target).data('data-id');
            console.log(objectId);
            app.controller.loadDeleteProduct(objectId);
        });
    }; //delete-button

    var entityMap = {
        "&": "&amp;",
        "<": "&lt;",
        ">": "&gt;",
        '"': '&quot;',
        "'": '&#39;',
        "/": '&#x2F;'
    };

    function escapeHtml(string) {
        return String(string).replace(/[&<>"'\/]/g, function (s) {
            return entityMap[s];
        });
    }

    return{
        get: function (data) {
            return new BaseController(data);
        }
    }
}());