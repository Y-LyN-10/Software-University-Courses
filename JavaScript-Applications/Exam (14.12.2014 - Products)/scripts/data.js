var app = app || {};

app.data = (function () {
    function Data(baseUrl, ajaxRequester){
        this.users = new Users(baseUrl, ajaxRequester);
        this.products = new Products(baseUrl, ajaxRequester);
    }

    var credentials = (function () {
        var headers = {
            'X-Parse-Application-Id' : 'kOEoKIXMc5bAVnSHhqrzK6Vs7TyrJp00AjlZn8v5',
            'X-Parse-REST-API-Key': 'tY1vkRNtiB6btljxr8lV72DpTJ92jQg5LsHi5ZSK',
            'X-Parse-Session-Token': getSessionToken()
        };

        function getSessionToken(){
            localStorage.getItem('sessionToken');
        }

        function setSessionToken(sessionToken){
            localStorage.setItem('sessionToken', sessionToken);
        }

        function getUsername(){
            localStorage.getItem('username');
        }

        function setUsername(sessionToken){
            localStorage.setItem('username', sessionToken);
        }

        function getHeaders(){
            return headers;
        }

        return {
            getSessionToken: getSessionToken,
            setSessionToken: setSessionToken,
            getUsername: getUsername,
            setUsername: setUsername,
            getHeaders: getHeaders
        }
    }());
    
    var Users = (function () {
        function Users(baseUrl, ajaxRequester){
            this._serviceUrl = baseUrl;
            this._ajaxRequester = ajaxRequester;
            this._headers = credentials.getHeaders();
        }

        Users.prototype.login = function (username, password) {
            var url = this._serviceUrl + 'login' + '?username=' + username + '&password=' + password;
            return this._ajaxRequester.get(url, this._headers)
                .then(function (data) {
                    credentials.setSessionToken(data.sessionToken);
                    credentials.setUsername(data.username);
                    return data;
                });
        };

        Users.prototype.logout = function () {
            localStorage.clear();
            return localStorage;
        };

        Users.prototype.register = function (username, password) {
            var userData = {
                username: username,
                password: password
            };

            var url = this._serviceUrl + 'users';
            return this._ajaxRequester.post(url, userData, this._headers)
                .then(function (data) {
                    credentials.setSessionToken(data.sessionToken);
                    return data;
                });
        };

        return Users;
    }());

    var Products = (function () {
        function Products(baseUrl, ajaxRequester){
            this._serviceUrl = baseUrl + 'classes/Product'; // test with EmptyClass for... empty list
            this._ajaxRequester = ajaxRequester;
            this._headers = credentials.getHeaders();
        }

        Products.prototype.getAll = function () {
            return this._ajaxRequester.get(this._serviceUrl, this._headers);
        };

        Products.prototype.add = function (product) {
            return this._ajaxRequester.post(this._serviceUrl, product, this._headers);
        };

        Products.prototype.delete = function (objectId) {
            return this._ajaxRequester.delete(this._serviceUrl + '/' + objectId, this._headers);
        };

        Products.prototype.getById = function (objectId) {
            return this._ajaxRequester.get(this._serviceUrl + '/' + objectId, this._headers);
        };

        return Products;
    }());

    return{
        get: function (baseUrl, ajaxRequester) {
            return new Data(baseUrl, ajaxRequester);
        }
    }
}());