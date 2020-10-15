//Conversion of values from one type to another type

//1. String(number): Converts a number into string
console.log("String():");
var a = 10;
var b = String(a);
console.log(a); //Output: 10
console.log(b); //Output: "10"

//2. toString(): Converts a number into string
console.log("toString():");
//a = undefined;
var c = a.toString();
console.log(a); //Output: 10
console.log(c); //Output: "10"

//3. Number(string): Converts a string into number
console.log("Number():");
var d = "100";
var e = Number(d);
console.log(d); //Output": 100"
console.log(e); //Output: 100
var f = "100abc";
var g = Number(f);
console.log(f); //Output: "100abc"
console.log(g); //Output: NaN  //Number() function returns NaN is the string value is alphanumeric
var h = "abc";
var i = Number(h);
console.log(h); //Output: "abc"
console.log(i); //Output: NaN  //Number() function returns NaN is the string value is alphanumeric

//4. parseInt(string): Converts a string into number
console.log("parseInt():");
var d = "100";
e = parseInt(d);
console.log(d); //Output": 100"
console.log(e); //Output: 100
f = "100abc";
g = parseInt(f);
console.log(f); //Output: "100abc"
console.log(g); //Output: NaN  //Number() function returns NaN is the string value is alphanumeric
h = "abc";
i = parseInt(h);
console.log(h); //Output: "abc"
console.log(i); //Output: NaN  //parseInt() function returns NaN is the string value is alphanumeric and begins with non-digit character


//5. parseFloat(string): Converts a string into number
console.log("parseFloat():");
var d = "100.24";
e = parseFloat(d);
console.log(d); //Output": 100"
console.log(e); //Output: 100
f = "100abc";
g = parseFloat(f);
console.log(f); //Output: "100abc"
console.log(g); //Output: NaN  //Number() function returns NaN is the string value is alphanumeric
h = "abc";
i = parseFloat(h);
console.log(h); //Output: "abc"
console.log(i); //Output: NaN  //parseFloat() function returns NaN is the string value is alphanumeric and begins with non-digit character