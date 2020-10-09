//Arrays methods
var a = [10, 20, 30, 40];

//every
console.log(a.every(
    function(x) {
        return x > 25;
    }
)); //Executes the callback function for every element of the array; and returns true if all elements matches with the specified condition

//Output: false

//some
console.log(a.some(
    function(x) {
        return x > 25;
    }
)); //Executes the callback function for every element of the array; and returns true if at least one element matches with the specified condition

//Output: true