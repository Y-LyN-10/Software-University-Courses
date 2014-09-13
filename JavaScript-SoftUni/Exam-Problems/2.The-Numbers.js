(function (){
    function solve(str) {
        var symbols = str[0].toString(),
            numbers = [], hexNumbers = [];
        numbers = symbols.split(/\D+/).filter(Boolean);

        numbers.forEach(function (number) {
            hexNumbers.push(dec2hex(Number(number)));
        });

        function dec2hex(i) {
            return (i+0x10000).toString(16).substr(-4).toUpperCase();
        }

        var result = '0x' + hexNumbers.join('-0x');
        return result;
    }

    var test1 = ['5tffwj(//*7837xzc2---34rlxXP%$".'];
    solve(test1);
}());

