var app = app || {};

app.dataPersister = (function() {
	function Persister(rootUrl) {
		this.rootUrl = rootUrl;
		this.headers = {
			"X-Parse-Application-Id" : "hidden-for-GitHub",
			"X-Parse-REST-API-Key" : "hidden-for-GitHub"
		},
		this.questions = new Questions(rootUrl, this.headers);
	}

	var Questions = (function() {
		function Questions(rootUrl, headers) {
			this.serviceUrl = rootUrl + 'Question/';
			this.headers = headers;
		}
		Questions.prototype.getAll = function(success, error) {
			return ajaxRequester.get(this.serviceUrl, this.headers, success, error);
		}
		Questions.prototype.vote = function(question, success, error) {
			return ajaxRequester.post(this.serviceUrl, this.headers, question, success, error);
		}

		return Questions;
	}());

	return {
		get: function(rootUrl, headers) {
			return new Persister(rootUrl);
		}
	}
}());