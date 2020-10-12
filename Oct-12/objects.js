//a is the reference variable that stores reference of the first object
var a = { customerID: 1, customerName: "Scott" };
//console.log(a); //{ customerID: 1, customerName: 'Scott' }

var b = { customerID: 2, customerName: "Smith" };
//console.log(b); //{ customerID: 2, customerName: 'Smith' }

var c = a;
a = b;
b = c;
console.log(a); //{ customerID: 2, customerName: 'Smith' }
console.log(b); //{ customerID: 1, customerName: 'Scott' }
console.log(a.customerID); //Output: 2
console.log(a.customerName); //Output: Smith
console.log(b.customerID); //Output: 1
console.log(b.customerName); //Output: Scott