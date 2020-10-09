//array  methods
var a = [10, 50, 80, 120, 300];
console.log(a); //Output: [10, 50, 80, 120, 300]

//push
a.push(500); //push: adds new value at end of the array3
console.log(a); //Output: [10, 50, 80, 120, 300, 500]

//splice (to remove)
a.splice(2, 1); //splice(index, count): splice removes one or more values
console.log(a); //Output: [10, 50, 120, 300, 500]

//splice (to insert)
a.splice(2, 0, 45); //splice(index, countToRemove, newValue): Removes nothing; but adds a new value at the specified index
console.log(a); //Output: [10, 50, 45, 120, 300, 500]

//concat
var b = a.concat([1000, 1100]); //concat( newArray ): Adds all elements of new array at the end of existing array
console.log(b); //Output: [10, 50, 45, 120, 300, 500, 1000, 1100]