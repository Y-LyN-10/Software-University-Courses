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
                // If you return name instead of _name, you'll get maximum call stack exceeded
                return this._name;
            }
            set name(name){
                // Keep it simple and readble :)
                if(!name){
                    throw new Error('Name cannot be empty or undefined');
                }
                this._name = name;
            }

            get position(){
                return this._position;
            }
            set position(position){
                if(!position){
                    throw new Error('Position cannot be empty or undefined');
                }
                this._position = position;
            }

            get grade(){
                return this._grade;
            }
            set grade(grade){
                if (!grade) {
                    throw new Error('Grade cannot be negative');
                }
                this._grade = grade;
            }

            toString(){
                // Yeah! ES6 Template strings using back ticks, how cool is that? :)
                return ` ---> ${this.name},position=${this.position}`;
            }
        }

        // Classes can hold only functions, so it's not possible to declare variables inside them
        // but wow: real constant that can't be changed :)
        const WHEELS = {
            bike: 2,
            truck: 4
        };

        // Creating enums in ES6 is still masochistic. It would be overkill here, so const is OK
        // If interested in enums in ES6, see that - https://gist.github.com/xmlking/e86e4f15ec32b12c4689
        const TERRAINS = {
            road: 'road',
            all: 'all'
        };

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
                if(brand.length === 0){
                    throw new Error('Vehicle brand should be a non-empty string');
                }
                this._brand = brand;
            }

            get age(){
                return this._age;
            }
            set age(age){
                if(age < 0){
                    throw new Error('Vehicle age should always be a non-negative number');
                }
                this._age = age.toFixed(1);
            }

            get terrain(){
                return this._terrain;
            }
            set terrain(terrain){
                if(Object.keys(TERRAINS).indexOf(terrain) === -1){
                    throw new Error('Vehicle terrain coverage can be either “road” or “all”');
                }

                this._terrain = terrain;
            }

            get wheels(){
                return this._wheels;
            }
            set wheels(wheels){
                if (wheels < 0){
                    throw new Error('Vehicle number of wheels should always be a non-negative number');
                }
                this._wheels = Math.round(wheels);
            }

            toString(vehicleType){
                // Well, following the OOP principles - that implementation with
                // vehicleType is not the best I guess, but it's to avoid code repetition
                // and it's more readable, which is more important in that es6 example
                return ` -> ${vehicleType}: brand=${this.brand},age=${this.age}` +
                `,terrainCoverage=${this.terrain},numberOfWheels=${this.wheels}`;
            }
        }

        class Bike extends Vehicle {
            constructor(brand, age, terrain, frame, shifts){
                super(brand, age, terrain, WHEELS.bike);

                this.frame = frame;
                this.shifts = shifts;
            }

            get frame(){
                return this._frame;
            }
            set frame(frame){
                if (frame < 0) {
                    throw new Error('Frame size of wheels cannot be negative');
                }
                this._frame = frame;
            }

            get shifts(){
                return this._shifts;
            }
            set shifts(shifts){
                if(shifts){
                    this._shifts = shifts;
                }
            }

            toString() {
                // super.toString() is equivalent to Vehicle.prototype.toString.call(this);
                let bike = super.toString(this.constructor.name);
                bike += `,frameSize=${this._frame}`;
            
                if(typeof this._shifts !== 'undefined'){
                    bike += `,numberOfShifts=${this._shifts}`;
                }

                return bike;
            };
        }

        class Automobile extends Vehicle {
            constructor(brand, age, terrain, wheels, consumption, fuel){
                super(brand, age, terrain, wheels);
                this.consumption = consumption;
                this.fuel = fuel;
            }

            get consumption(){
                return this._consumption;
            }

            set consumption(consumption){
                this._consumption = consumption;
            }

            get fuel(){
                return this._fuel;
            }

            set fuel(fuel){
                this._fuel = fuel;
            }

            toString() {
                let automobile = super.toString(this.constructor.name);
                automobile += `,consumption=[${this.consumption}l/100km ${this.fuel}]`;

                return automobile;
            };
        }

        class Truck extends Automobile {
            // How awesome it would be to set terrain=TERRAINS.all as default here?
            // Yeah, we can do that with ES6, but... this feature is not implemented in nodejs/iojs yet
            // Maybe it works at the last versions of Firefox
            constructor(brand, age, terrain, consumption, fuel, doors){
                // Then - the old good method to set defaults would be fine:
                // terrain = terrain || TERRAINS.all;
                // but we can't write anything before the 'super' function, because
                // a 'super' constructor call may only appear as the first statement of a function

                super(brand, age, terrain || TERRAINS.all, WHEELS.truck, consumption, fuel);
                // but - WOW, what I just did? It's not in the books... oh, that's why I love JavaScript ^^
                this.doors = doors;
            }

            get doors() {
                return this._doors;
            }

            set doors(doors){
                this._doors = doors;
            }

            toString() {
                return super.toString(this.constructor.name) + `,numberOfDoors=${this.doors}`;
            };
        }

        class Limo extends Automobile {
            constructor(brand, age, wheels, consumption, fuel, employees){
                super(brand, age, TERRAINS.road, wheels, consumption, fuel);
                this.employees = []; // TODO: Try to rewrite it with Set
            }

            get employees(){
                return this._employees;
            }

            set employees(employees){
                this._employees = employees;
            }

            // Not sure if these functions should be inside Limo class...
            appendEmployee(employee){
                if (this._employees.indexOf(employee) === -1) {
                    this._employees.push(employee);
                }
            }

            detachEmployee(employee){
                let index = this._employees.indexOf(employee);
                if (index === -1) {
                    // well, I have a feeling that this is already implemented somewhere >.<
                    throw new Error('Employee doesn\'t exist');
                }

                this._employees.splice(index, 1);
            }

            toString() {
                let limo = super.toString(this.constructor.name);

                limo += "\n" + " --> Employees, allowed to drive:";
                if (this.employees.length === 0) {
                    limo += " ---";
                }

                // Ah, fat arrow functions in ES6 :) Pure lambdas!
                limo += this.employees.map(e => '\n' + e.toString()).join('');

                return limo;
            };
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
                            if (t instanceof Models.Limo && t.employees.indexOf(object) !== -1) {
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
                        _vehicles[i].brand === brand) {
                        // I had to change getBrand to brand, because it wasn't working properly
                        return _vehicles[i];
                    }
                }
                throw new Error('No Limo with such brand exists');
            }

            function getLimosByBrand(brand) {
                var currentVehicles = [];
                for (var i=0; i < _vehicles.length; i++) {
                    if (_vehicles[i] instanceof Models.Limo &&
                        _vehicles[i].brand === brand) {
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
                    if (_employees[i].name === name) {
                        return _employees[i];
                    }
                }
                throw new Error('No Employee with such name exists.');
            }

            function formatOutputList(output) {
                var queryString = 'List Output:' + '\n';

                if (output.length > 0) {
                    queryString += output.join("\n");
                } else {
                    queryString = 'No results.';
                }

                return queryString;
            }

            function processListEmployees(commandArgs){
                var grade = commandArgs['grade'];

                // Use fat arrow functions as well :)
                _employees.sort((a, b) => a.name > b.name);

                var result = 'List Output:' + '\n';

                // In ES7 it will be possible to write Python-like array comprehensions ^^
                //[for (e of _employees) if (e.grade >= grade || grade === 'all') e];

                // But not now... so, let's use the functional power of JavaScript!
                result += _employees
                    .filter(e => e.grade >= grade || grade === 'all')
                    //.map(e => e.toString().trim())
                    .join('\n');

                return result;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processListEmployees: processListEmployees,
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
