//Array: collection of values of any type
var a = [10, 40, 300];
console.log(a); //Output: [ 10, 40 300]
console.log(a[0]); //Output: 10
console.log(a[1]); //Output: 40
console.log(a[2]); //Output: 300
console.log(a[3]); //Output: undefined

//for
console.log("\nfor loop:");
for (let i = 0; i < a.length; i++) {
    console.log(a[i]); //10 40 300
}