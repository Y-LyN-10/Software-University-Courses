(function () {
	var rootUrl = 'https://api.parse.com/1/classes/';
	var dataPersister = app.dataPersister.get(rootUrl);
	var controller = app.controller.get(dataPersister);
	
	controller.load('#wrapper');
}())