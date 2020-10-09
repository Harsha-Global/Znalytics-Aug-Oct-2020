//Arithemtical Operators
var a = 10;
var b = 3;
var c = a + b; //addition
var d = a - b; //subtraction
var e = a * b; //multiplication
var f = a / b; //division
var g = a % b; //remainder (modulo)
console.log(c); //Output: 13
console.log(d); //Output: 7
console.log(e); //Output: 30
console.log(f); //Output: 3.33333333333
console.log(g); //Output: 1

//Assignment Operators
a = 10; //assigns to
console.log(a); //Output: 10
a += 3; //add and assign    a = a + 3
console.log(a); //Output: 13
a -= 3; //subtract and assign    a = a - 3
console.log(a); //Output: 10
a *= 3; //multiply and assign    a = a * 3
console.log(a); //Output: 30
a /= 3; //multiply and assign    a = a / 3
console.log(a); //Output: 10
a %= 3; //remainder assigns    a = a / 3
console.log(a); //Output: 1


//Increment / Decrement Operators
a = 10;
console.log(a++); //Post incrementation....Output: 10  and internally 'a' value becomes 11
console.log(a); //Output: 11
console.log(a--); //Post decrementation....Output: 11  and internally 'a' value becomes 10
console.log(a); //Output: 10
console.log(++a); //Pre incrementation....Output: 11
console.log(a); //Output: 11
console.log(--a); //Pre decrementation....Output: 10
console.log(a); //Output: 10


//Relational Operators
a = 10;
b = 3;
console.log(a == b); //Output: false
console.log(a != b); //Output: true
console.log(a < b); //Output: false
console.log(a <= b); //Output: false
console.log(a > b); //Output: true
console.log(a >= b); //Output: true


//Logical Operators
a = 10;
b = 3;
c = 20;
d = (a > b) && (c > b); //Both conditions should be true
console.log(d); //true
d = (a > b) && (c < b); //Both conditions should be true
console.log(d); //false
e = (a > b) || (c < b); //At least any one condition should be true
console.log(e); //true


//Concatenation Operator
a = "Hello";
b = "World";
c = a + b; //Attaches the second operand at the end of first operand
console.log(c); //Output: HelloWorld

//Template Literals
var name = "Scott",
    age = 20;
var message = `Hello ${name} - your age is ${age}`;
console.log(message); //Output: Hello Scott - your age is 20

//Hoisting
console.log(xyz); //Output: undefined
var xyz = 1000; //Variables declared anywhere in the program are hoisted-up (lifted-up) automatically towards the top of the program. But assignment will not be hoisted.

//let
let msg = "Hello";
let n = 10;

//let supports local variables, global variables and block level variables.
//var  supports local variables, global variables but not block level variables.