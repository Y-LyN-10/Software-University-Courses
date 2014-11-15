function processTrainingCenterCommands(commands) {
    'use strict';

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    var Validators = {
        validateNonEmptyString: function (value, variableName) {
            if (typeof (value) !== 'string' || !value) {
                throw new Error(variableName + " should be non-empty string.");
            }
        },

        validateEmail: function (value, variableName) {
            if (value.indexOf('@') === -1) {
                throw new Error(variableName + " is not valid.");
            }
        },

        validateDate: function (date, variableName) {
            var day = date.getDate();
            var monthName = date.toString().split(' ')[1];
            var year = date.getFullYear();

            Validators.validateIntegerRange(day, 'day', 1, 31);
            Validators.validateIntegerRange(year, 'year', 2000, 2020);
        },

        validateIntegerRange: function (value, variableName, minValue, maxValue) {
            if (value !== parseInt(value, 10)) {
                throw new Error(variableName + " should be integer.");
            }

            if (value < minValue || value > maxValue) {
                throw new Error(variableName + ' should be integer in the range [' +
                    minValue + '...' + maxValue + '].');
            }
        },

        validateNonEmptyObject: function (value, className, variableName) {
            if (! (value instanceof className)) {
                throw new Error(variableName + " should be non-empty " +
                    className.prototype.constructor.name + ".");
            }
        }
    };

    var trainingCenter = (function () {
        var TrainingCenterEngine = (function () {
            var _trainers,
                _uniqueTrainerUsernames,
                _trainings;

            function initialize() {
                _trainers = [];
                _uniqueTrainerUsernames = {};
                _trainings = [];
            }

            function executeCommand(command) {
                var cmdParts = command.split(' ');
                var cmdName = cmdParts[0];
                var cmdArgs = cmdParts.splice(1);

                switch (cmdName) {
                    case 'create':
                        return executeCreateCommand(cmdArgs);
                    case 'list':
                        return executeListCommand();
                    case 'delete':
                        return executeDeleteCommand(cmdArgs);
                    default:
                        throw new Error('Unknown command: ' + cmdName);
                }
            }

            function executeCreateCommand(cmdArgs) {
                var objectType = cmdArgs[0];
                var createArgs = cmdArgs.splice(1).join(' ');
                var objectData = JSON.parse(createArgs);
                var trainer;
                switch (objectType) {
                    case 'Trainer':
                        trainer = new trainingCenter.Trainer(objectData.username, objectData.firstName,
                            objectData.lastName, objectData.email);
                        addTrainer(trainer);
                        break;
                    case 'Course':
                        trainer = findTrainerByUsername(objectData.trainer);
                        var course = new trainingCenter.Course(objectData.name, objectData.description, trainer,
                            parseDate(objectData.startDate), objectData.duration);
                        addTraining(course);
                        break;
                    case 'Seminar':
                        trainer = findTrainerByUsername(objectData.trainer);
                        var seminar = new trainingCenter.Seminar(objectData.name, objectData.description,
                            trainer, parseDate(objectData.date));
                        addTraining(seminar);
                        break;
                    case 'RemoteCourse':
                        trainer = findTrainerByUsername(objectData.trainer);
                        var remoteCourse = new trainingCenter.RemoteCourse(objectData.name, objectData.description,
                            trainer, parseDate(objectData.startDate), objectData.duration, objectData.location);
                        addTraining(remoteCourse);
                        break;
                    default:
                        throw new Error('Unknown object to create: ' + objectType);
                }
                return objectType + ' created.';
            }

            function findTrainerByUsername(username) {
                if (!username) {
                    return undefined;
                }
                for (var i = 0; i < _trainers.length; i++) {
                    if (_trainers[i].getUsername() === username) {
                        return _trainers[i];
                    }
                }
                throw new Error('Trainer not found: ' + username);
            }

            function addTrainer(trainer) {
                if (_uniqueTrainerUsernames[trainer.getUsername()]) {
                    throw new Error('Duplicated trainer: ' + trainer.getUsername());
                }
                _uniqueTrainerUsernames[trainer.getUsername()] = true;
                _trainers.push(trainer);
            }

            function deleteTrainer(trainer) {
                findTrainerByUsername(trainer);

                for (var i = 0; i < _trainers.length; i++) {
                    if (_trainers[i].getUsername() === trainer) {
                        _uniqueTrainerUsernames[_trainers[i].getUsername()] = false;
                        _trainers.splice([i], 1);
                    }
                }

                for (var j = 0; j < _trainings.length; j++) {
                    if (_trainings[j].getTrainer() !== undefined) {
                        if (_trainings[j].getTrainer().getUsername() === trainer) {
                            _trainings[j]._trainer = undefined;
                        }
                    }
                }
            }

            function addTraining(training) {
                _trainings.push(training);
            }

            function executeListCommand() {
                var result = '', i;
                if (_trainers.length > 0) {
                    result += 'Trainers:\n' + ' * ' + _trainers.join('\n * ') + '\n';
                } else {
                    result += 'No trainers\n';
                }

                if (_trainings.length > 0) {
                    result += 'Trainings:\n' + ' * ' + _trainings.join('\n * ') + '\n';
                } else {
                    result += 'No trainings\n';
                }

                return result.trim();
            }

            function executeDeleteCommand(cmdArgs) {
                var objectType = cmdArgs[0];
                var deleteArgs = cmdArgs.splice(1).join(' ');
                switch (objectType) {
                    case 'Trainer':
                        deleteTrainer(deleteArgs);
                        break;
                    default:
                        throw new Error('Unknown object to delete: ' + objectType);
                }
                return objectType + ' deleted.';
            }

            var trainingCenterEngine = {
                initialize: initialize,
                executeCommand: executeCommand
            };
            return trainingCenterEngine;
        }());

        var Trainer = (function () {
            function Trainer(username, firstName, lastName, email) {
                this.setUsername(username);
                this.setFirstName(firstName);
                this.setLastName(lastName);
                this.setEmail(email);
            }

            Trainer.prototype.getUsername = function () {
                return this._username;
            };
            Trainer.prototype.setUsername = function (username) {
                if (username !== undefined) {
                    Validators.validateNonEmptyString(username, "username");
                } else {
                    throw new Error('Can\'t create Trainer with no username');
                }

                this._username = username;
            };

            Trainer.prototype.getFirstName = function () {
                return this._firstName;
            };
            Trainer.prototype.setFirstName = function (firstName) {
                if(firstName !== undefined){
                    Validators.validateNonEmptyString(firstName, "firstName");
                }
                this._firstName = firstName;
            };

            Trainer.prototype.getLastName = function () {
                return this._lastName;
            };
            Trainer.prototype.setLastName = function (lastName) {
                Validators.validateNonEmptyString(lastName, "lastName");
                this._lastName = lastName;
            };

            Trainer.prototype.getEmail = function () {
                return this._email;
            };
            Trainer.prototype.setEmail = function (email) {
                if (email !== undefined) {
                    Validators.validateEmail(email, "email");
                }

                this._email = email;
            };

            Trainer.prototype.toString = function () {
                var result = 'Trainer[username=' + this.getUsername();

                if (this.getFirstName() !== undefined) {
                    result += ';first-name=' + this.getFirstName();
                }

                result += ';last-name=' + this.getLastName();

                if (this.getEmail() !== undefined) {
                    result += ';email=' + this.getEmail();
                }

                result += ']';

                return result;
            };

            return Trainer;
        }());

        var Training = (function () {
            function Training(name, description, trainer, startDate, duration) {
                if (this.constructor === Training) {
                    throw new Error('Can\'t instantiate abstract class Estate');
                }

                this.setName(name);
                this.setDescription(description);
                this.setTrainer(trainer);
                this.setStartDate(startDate);
                this.setDuration(duration);
            }

            Training.prototype.getName = function () {
                return this._name;
            };
            Training.prototype.setName = function (name) {
                Validators.validateNonEmptyString(name, "name");
                this._name = name;
            };

            Training.prototype.getDescription = function () {
                return this._description;
            };
            Training.prototype.setDescription = function (description) {
                if (description !== undefined) {
                    Validators.validateNonEmptyString(description, "description");
                }
                this._description = description;
            };

            Training.prototype.getStartDate = function () {
                return this._startDate;
            };
            Training.prototype.setStartDate = function (startDate) {
                Validators.validateDate(startDate);
                this._startDate = formatDate(startDate);
            };

            Training.prototype.getTrainer = function () {
                return this._trainer;
            };
            Training.prototype.setTrainer = function (trainer) {
                if(trainer !== undefined){
                    Validators.validateNonEmptyObject(trainer, Trainer, 'trainer');
                }
                this._trainer = trainer;
            };

            Training.prototype.getDuration = function () {
                return this._duration;
            };
            Training.prototype.setDuration = function (duration) {
                if (duration !== undefined) {
                    Validators.validateIntegerRange(duration, "duration", 1, 99);
                }
                this._duration = duration;
            };

            Training.prototype.toString = function () {
                var result = '[name=' + this.getName();

                // TODO: Better checks?
                if (this.getDescription() !== undefined) {
                    result += ';description=' + this.getDescription();
                }

                if (this.getTrainer() !== undefined) {
                    result += (';trainer=' + this.getTrainer());
                }

                if (this.constructor.name === 'Seminar') {
                    result += ';date=' + this.getStartDate();
                } else {
                    result += ';start-date=' + this.getStartDate();
                }

                if (this.getDuration() !== undefined) {
                    result += ';duration=' + this.getDuration();
                }

                return result;
            };

            return Training;
        }());

        var Course = (function () {
            function Course(name, description, trainer, startDate, duration) {
                Training.call(this, name, description, trainer, startDate, duration);
            }

            Course.extends(Training);

            Course.prototype.toString = function () {
                return 'Course' + Training.prototype.toString.call(this) + ']';
            };

            return Course;
        }());

        var Seminar = (function () {
            function Seminar(name, description, trainer, startDate) {
                Training.call(this, name, description, trainer, startDate);
            }

            Seminar.extends(Training);

            Seminar.prototype.toString = function () {
                return 'Seminar' + Training.prototype.toString.call(this) + ']';
            };

            return Seminar;
        }());

        var RemoteCourse = (function () {
            function RemoteCourse(name, description, trainer, startDate, duration, location) {
                Training.call(this, name, description, trainer, startDate, duration);
                this.setLocation(location);
            }

            RemoteCourse.extends(Course);

            RemoteCourse.prototype.getLocation = function () {
                return this._location;
            };
            RemoteCourse.prototype.setLocation = function (location) {
                if (location !== undefined) {
                    Validators.validateNonEmptyString(location, 'location');
                } else {
                    throw new Error('Can\'t create Remote course with no location');
                }

                this._location = location;
            };

            RemoteCourse.prototype.toString = function () {
                return 'RemoteCourse' + Training.prototype.toString.call(this) +
                    ';location=' + this.getLocation() + ']';
            };

            return RemoteCourse;
        }());

        var trainingCenter = {
            Trainer: Trainer,
            Course: Course,
            Seminar: Seminar,
            RemoteCourse: RemoteCourse,
            engine: {
                TrainingCenterEngine: TrainingCenterEngine
            }
        };

        return trainingCenter;
    })();

    var parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }

        return date;
    };

    var formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();

        return day + '-' + monthName + '-' + year;
    };

    // Process the input commands and return the results
    var results = '';
    trainingCenter.engine.TrainingCenterEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd != '') {
            try {
                var cmdResult = trainingCenter.engine.TrainingCenterEngine.executeCommand(cmd);
                results += cmdResult + '\n';
            } catch (err) {
                //console.log(err.stack);
                results += 'Invalid command.\n';
            }
        }
    });
    return results.trim();
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function () {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function (line) {
            arr.push(line);
        }).on('close', function () {
            console.log(processTrainingCenterCommands(arr));
        });
    }
})();
