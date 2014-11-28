var app = app || {};

app.controller = (function () {
	function Controller(dataPersister) {
		this.persister = dataPersister;
	}

	Controller.prototype.load = function (selector) {
		var _this = this;

		this.persister.questions.getAll(
			function (data) {
				_this.loadQuestions(data);
			},
			function (error) {
				console.log(error);
			}
		);
	}

	function attachQuestionToDom(element, question) {
		var questionWrapper = $('<li />');
		questionWrapper.attr('data-id', question.objectId);
		var questionText = $('<div />').append('Question: ' + question.questionText);
		var answersForm = $('<form />');

		var answers = question.Answers;
		var voteButton = $('');

		Object.keys(answers).forEach(function (key, index) {
			var inputRadio = ('<input type="radio" name="answer" id=answer'+ index +'>');
			var label = '<label for="answer'+ index +'">'+ key +'</label>';

			answersForm.append(inputRadio);
			answersForm.append(label);	
			answersForm.append('<hr/>');
		});

		questionWrapper.append(questionText);
		questionWrapper.append(answersForm);
		element.append(questionWrapper);
	}

	Controller.prototype.loadQuestions = function (data) {
		var selector = '#questions';
		var allQuestionsWrapper = $(selector);

		// console.log(data);
		data.results.forEach(function(questionData, index){
			// console.log(questionData);
			attachQuestionToDom(allQuestionsWrapper, questionData);
		});
	}

	return {
		get: function (dataPersister) {
			return new Controller(dataPersister);
		}
	}
}())