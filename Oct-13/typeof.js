//data types & typeof & null
var a;
console.log(typeof a); //Output: undefined
a = 100.349;
console.log(typeof a); //Output: number
a = "Hello123";
console.log(typeof a); //Output: string
a = true;
console.log(typeof a); //Output: boolean
a = {};
console.log(typeof a); //Output: object
a = new Object();
console.log(typeof a); //Output: object
a = [];
console.log(typeof a); //Output: object
a = function() {};
console.log(typeof a); //Output: function
a = () => {};
console.log(typeof a); //Output: function
a = null;
console.log(typeof a); //Output: object

//undefined: default value of all variables
//null: we have to assign manually, if needed


//== vs ===
var x = 10,
    y = "10";
console.log(x == y); //Output: true   //== checks only value
console.log(x === y); //Output: true  //=== checks data type and also value