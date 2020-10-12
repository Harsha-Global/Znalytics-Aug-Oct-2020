//slice(startIndex, endIndex): It returns a new array that contains elements between startIndex and endIndex, including startIndex but excluding endIndex.

//create array
var marks = [23, 78, 60, 34, 50, 92, 80, 34, 76, 22];

//get elements between 2 to 4
var ind = marks.indexOf(60);
var result = marks.slice(ind, ind + 5);
console.log(result); //Output: [ 60, 34, 50, 92, 80 ]