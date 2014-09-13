function Solve(args){
    var numbers,
        count = 1,
        maxCount = 1,
        oldWord,
        newWord,
        i;

    numbers = args[0].split(/[ ()]+/).filter(Boolean);

    oldWord = checkNumber(numbers[0]);

    function checkNumber(number){
        if (number % 2 === 0) {
            return (number === '0') ? {} : 'even';
        } else {
            return 'odd';
        }
    }

    for (i = 0; i < numbers.length-1; i+=1) {
        newWord = checkNumber(numbers[i+1]);

        if(oldWord !== newWord){
            count++;
            if(maxCount < count){
                maxCount = count;
            }
        } else {
            count = 1;
        }

        oldWord = newWord;
    }

    console.log(maxCount);
}

var zeroTests = [
    ['(3) (22) (-18) (55) (44) (3) (21)'], // 4
    ['(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)'], // 10
    ['  ( 2 )  ( 33 ) (1) (4)   (  -1  ) '], // 3
    ['(102)(103)(0)(105)  (107)(1)'], // 4
    ['(2) (2) (2) (2) (2)'], // 1
    ['(0)(0) (0) (0) (0)(0)'] // 6
];

Solve(zeroTests[5]);

//Judge System: 80/100...