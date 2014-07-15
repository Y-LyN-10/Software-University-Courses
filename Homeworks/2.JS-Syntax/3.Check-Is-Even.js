'use strict';

var isEven = function(value){
    if(value %2 === 0) {
        return true;
    }else{
        return false;
    }
}

console.log(isEven(3));
console.log(isEven(127));
console.log(isEven(588));