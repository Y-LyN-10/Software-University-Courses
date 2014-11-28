var ajaxRequester = (function () {
	var makeRequest = function makeRequest(method, url, headers, data, success, error) {
		return $.ajax({
			type: method,
			headers: headers,
			url: url,
			contentType: 'application/json',
			data: JSON.stringify(data),
			success: success,
			error: error
		})
	}

	function makeGetRequest(url, headers, success, error) {
		return makeRequest('GET', url, headers, null, success, error);
	}
	
	function makePostRequest(url, headers, data, success, error) {
		return makeRequest('POST', url, headers, data, success, error);
	}

	function makePutRequest(url, headers, data, success, error) {
		return makeRequest('PUT', url, headers, data, success, error);
	}

	function makeDeleteRequest(url, headers, success, error) {
		return makeRequest('DELETE', url, headers, {}, success, error);
	}

	return {
		get: makeGetRequest,
		post: makePostRequest,
		put: makePutRequest,
		delete: makeDeleteRequest
	}
}());