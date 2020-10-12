//destructuring: Converts elements of an array into respective variables
var states = ["Tamil nadu", "Uttar Pradesh", "Maha Rashtra", "Kerala", "Karnataka", "Andhra Pradesh"];

//regular code
// var a, b, c;
// a = states[0];
// b = states[1];
// c = states[2];

//new code: 2015 version (ES6 or ES2015)
var [a, b, ...c] = states;

//... is 'rest' (remaining) operator

console.log(a); //Output: Tamil nadu
console.log(b); //Output: Maha Rashtra
console.log(c); //Output: ["Maha Rashtra", "Kerala", "Karnataka", "Andhra Pradesh"]