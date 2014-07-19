/*  Problem 5.	Decimal to Hexadecimal
 Write a JavaScript code in a Web page dec2hex.html that enters a positive integer number
 num and converts and converts it to a hexadecimal form. The input should be entered as
 JavaScript prompt window. The output should be shown as browser popup window (alert).  */

// Only console working for now.
function convertDecToHex(decNumber) {
    var answer = '';

    if (decNumber < 0) {
        return false;
        //TODO: Throw an exception
    } else {

        while (decNumber != 0) {
            if (decNumber % 16 > 9) {
                switch (decNumber % 16) {
                    case 10:
                        answer = "A" + answer;
                        break;
                    case 11:
                        answer = "B" + answer;
                        break;
                    case 12:
                        answer = "C" + answer;
                        break;
                    case 13:
                        answer = "D" + answer;
                        break;
                    case 14:
                        answer = "E" + answer;
                        break;
                    case 15:
                        answer = "F" + answer;
                        break;
                }
            } else {
                answer = decNumber % 16 + answer;
            }
            decNumber = decNumber / 16;
        }
        return answer;
    }
}

convertDecToHex(254);