(function () {
    function solve(input) {
        var cloudManager = { };

        for (var i in input) {
            var data = input[i].split(' ');
            var name = data[0].trim();
            var ext = data[1].trim();
            var memory = parseFloat(data[2].trim());

            if (!cloudManager[ext]) {
                cloudManager[ext] = {files: [], memory: 0};
            }
            if (!cloudManager[ext]['files']) {
                cloudManager[ext]['files'] = [];
            }
            if (cloudManager[ext]['files'].indexOf(name) == -1) {
                cloudManager[ext]['files'].push(name);
            }
            cloudManager[ext]['memory'] =  parseFloat(parseFloat(cloudManager[ext]['memory']) + memory).toFixed(2);
        }

        // Sort the cloudManager structure
        cloudManager = sortObjectProperties(cloudManager);
        for (var extension in cloudManager) {
            cloudManager[ext] = sortObjectProperties(cloudManager[ext]);
            for (var file in cloudManager[ext]) {
                cloudManager[ext]['files'].sort();
            }
        }

        // Print the cloudManager as JSON string
        console.log(JSON.stringify(cloudManager));

        function sortObjectProperties(obj) {
            var keysSorted = Object.keys(obj).sort();
            var sortedObj = {};
            for (var i = 0; i < keysSorted.length; i++) {
                var key = keysSorted[i];
                sortedObj[key] = obj[key];
            }
            return sortedObj;
        }
    }

    var test1 = [
        'sentinel .exe 15MB',
        'zoomIt .msi 3MB',
        'skype .exe 45MB',
        'trojanStopper .bat 23MB',
        'kindleInstaller .exe 120MB',
        'setup .msi 33.4MB',
        'winBlock .bat 1MB'
    ];

    solve(test1);
}());