function processVehicleParkCommands(commands) {
    'use strict';

    var Models = (function() {

        // Using ES6 Classes
        class Employee {
            constructor(name, position, grade){
                this.name = name;
                this.position = position;
                this.grade = grade;
            }

            get name(){
                return this._name;
            }
            set name(name){
                if(!name){
                    throw new Error("Name cannot be empty or undefined.");
                }
                this._name = name;
            }

            get position(){
                return this._position;
            }
            set position(position){
                if(!position){
                    throw new Error("Position cannot be empty or undefined.");
                }
                this._position = position;
            }

            get grade(){
                return this._grade;
            }
            set grade(grade){
                if (!grade) {
                    throw new Error("Grade cannot be negative.");
                }
                this._grade = grade;
            }

            toString(){
                return ` ---> ${this.getName()},position= ${this.getPosition()}`;
            }
        }

        class Vehicle {
            constructor(brand, age, terrain, wheels){
                this.brand = brand;
                this.age = age;
                this.terrain = terrain;
                this.wheels = wheels;
            }

            get brand(){
                return this._brand;
            }
            set brand(brand){
                this._brand = brand;
            }

            get age(){
                return this._age;
            }
            set age(age){
                this._age = age.toFixed(1);
            }

            get terrain(){
                return this._terrain;
            }
            set terrain(terrain){
                if(terrain){
                    this._terrain = terrain;
                }
            }

            get wheels(){
                return this._wheels;
            }
            set wheels(wheels){
                if (!wheels){
                    throw new Error('Vehicle number of wheels should always be a non-negative number');
                }
                this._wheels = Math.round(wheels);
            }

            toString(){
                var vehicle = ` -> ${this.constructor.name}: `;

                vehicle += `brand=${this.brand},age=${this.age},terrainCoverage=${this.terrain},numberOfWheels=${this.wheels}`;

                return vehicle;
            }
        }

        class Bike extends Vehicle {
            //const BIKE_WHEELS = 2;

            constructor(brand, age, terrain, frame, shifts, wheels){
                super(brand, age, terrain, wheels=2);
                this.frame = frame;
                this.shifts = shifts;
            }

            get frame(){
                return this._frame;
            }
            set frame(frame){
                if (!frame) {
                    throw new Error("Frame size of wheels cannot be negative.");
                }
                this._frame = frame;
            }

            get shifts(){
                return this._shifts;
            }
            set shifts(shifts){
                if (shifts) {
                    this._shifts = shifts;
                } else {
                    this._shifts = '';
                }
            }

            toString() {
                //super();
                //var bike = '';
                var bike = Vehicle.prototype.toString.call(this);

                bike += `,frameSize=${this._frame}`;
                if(typeof this._shifts !== 'undefined'){
                    bike += `,numberOfShifts=${this._shifts}`;
                }

                return bike;
            };
        }

        class Automobile extends Vehicle {
            // TODO: Implement this class
        }

        class Truck extends Vehicle {
            // TODO: Implement this class
        }

        class Limo extends Vehicle {
            // TODO: Implement this class
        }

        return {
            Employee: Employee,
            Bike: Bike,
            Automobile: Automobile,
            Truck: Truck,
            Limo: Limo
        }

    }());

    var ParkManager = (function(){
        var _vehicles;
        var _employees;

        function init() {
            _vehicles = [];
            _employees = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "bike":
                        object = new Models.Bike(
                            command["brand"],
                            parseFloat(command["age"]),
                            command["terrain-coverage"],
                            parseFloat(command["frame-size"]),
                            command["number-of-shifts"]);
                        _vehicles.push(object);
                        break;
                    case "truck":
                        object = new Models.Truck(
                            command["brand"],
                            parseFloat(command["age"]),
                            command["terrain-coverage"],
                            parseFloat(command["consumption"]),
                            command["type-of-fuel"],
                            parseFloat(command["number-of-doors"]));
                        _vehicles.push(object);
                        break;
                    case "limo":
                        object = new Models.Limo(
                            command["brand"],
                            parseFloat(command["age"]),
                            parseFloat(command["number-of-wheels"]),
                            parseFloat(command["consumption"]),
                            command["type-of-fuel"]);
                        _vehicles.push(object);
                        break;
                    case "employee":
                        object = new Models.Employee(command["name"], command["position"], parseFloat(command["grade"]));
                        _employees.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index;

                switch (command["type"]) {
                    case "employee":
                        object = getEmployeeByName(command["name"]);
                        _vehicles.forEach(function(t) {
                            if (t instanceof Models.Limo && t.getEmployees().indexOf(object) !== -1) {
                                t.detachEmployee(object);
                            }
                        });
                        index = _employees.indexOf(object);
                        _employees.splice(index, 1);
                        break;
                    case "bike":
                    case "truck":
                    case "limo":
                        object = getVehicleByBrandAndType(command['brand'],command['type']);
                        index = _vehicles.indexOf(object);
                        _vehicles.splice(index, 1);
                        break;
                    default:
                        throw new Error('Unknown type.');
                }

                return object.constructor.name + ' deleted.';
            }

            function processListCommand(command) {
                return formatOutputList(_vehicles);
            }

            function processAppendEmployeeCommand(command) {
                var employee = getEmployeeByName(command['name']);
                var limos = getLimosByBrand(command['brand']);

                for (var i=0; i < limos.length; i++) {
                    limos[i].appendEmployee(employee);
                }
                return 'Added employee to possible Limos.';
            }

            function processDetachEmployeeCommand(command) {
                var employee = getEmployeeByName(command['name']);
                var limos = getLimosByBrand(command['brand']);

                for (var i=0; i < limos.length; i++) {
                    limos[i].detachEmployee(employee);
                }

                return 'Removed employee from possible Limos.';
            }

            // Functions below are not revealed

            function getVehicleByBrandAndType(brand, type) {
                for (var i=0; i < _vehicles.length; i++) {
                    if (_vehicles[i].constructor.name.toString().toLowerCase() === type &&
                        _vehicles[i].getBrand() === brand) {
                        return _vehicles[i];
                    }
                }
                throw new Error('No Limo with such brand exists.');
            }

            function getLimosByBrand(brand) {
                var currentVehicles = [];
                for (var i=0; i < _vehicles.length; i++) {
                    if (_vehicles[i] instanceof Models.Limo &&
                        _vehicles[i].getBrand() === brand) {
                        currentVehicles.push(_vehicles[i]);
                    }
                }
                if (currentVehicles.length > 0) {
                    return currentVehicles;
                }
                throw new Error('No Limo with such brand exists.');
            }

            function getEmployeeByName(name) {

                for (var i = 0; i < _employees.length; i++) {
                    if (_employees[i].getName() === name) {
                        return _employees[i];
                    }
                }
                throw new Error('No Employee with such name exists.');
            }

            function formatOutputList(output) {
                var queryString = 'List Output:\n';

                if (output.length > 0) {
                    queryString += output.join("\n");
                } else {
                    queryString = 'No results.';
                }

                return queryString;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAppendEmployeeCommand: processAppendEmployeeCommand,
                processDetachEmployeeCommand: processDetachEmployeeCommand
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split('(');
                parameters['command'] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs['command'],
                output;

            switch (action) {
                case 'insert':
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case 'delete':
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case 'append-employee':
                    output = CommandProcessor.processAppendEmployeeCommand(commandArgs);
                    break;
                case 'detach-employee':
                    output = CommandProcessor.processDetachEmployeeCommand(commandArgs);
                    break;
                case 'list':
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case 'list-employees':
                    output = CommandProcessor.processListEmployees(commandArgs);
                    break;
                default:
                    throw new Error('Unsupported command.');
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var output = '';
    ParkManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != '') {
            try {
                result = ParkManager.executeCommands(cmd) + '\n';
            } catch (e) {
                result = 'Invalid command.' + '\n';
                result = e.message + "\n";
            }
            output += result;
        }
    });

    return output;
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processVehicleParkCommands(arr));
        });
    }
})();