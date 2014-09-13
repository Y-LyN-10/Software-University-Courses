(function () {
    function solve(args) {
        var bill = parseFloat(args[0]),
            mood = args[1].toLowerCase(),
            tip = 0, n;

        switch(mood){
            case 'happy': tip = (bill*10)/100; break;
            case 'married': tip = (bill*0.05)/100; break;
            case 'drunk': {
                var percent = ((bill*15)/100);
                var percentToString = percent.toString();
                var n = parseInt(percentToString[0]);
                tip = Math.pow(percent, n);
            } break;
            default: tip = (bill*5)/100; break;
        }

        return tip.toFixed(2);
    }

    var test1 = ['120.44', 'happy'];
    var test2 = ['1230.83', 'drunk'];
    var test3 = ['716.00', 'married'];
    var test4 = ['0', 'happy'];

    console.log(solve(test2));
}());