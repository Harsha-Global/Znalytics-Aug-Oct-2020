//indexof: to get index of the first occurrence of the specified element in the array.

var marks = [23, 78, 60, 34, 50, 92, 60, 99, 28, 60, 41];

var indexOf60 = marks.indexOf(60);
console.log("First occurrence of 60: " + indexOf60); //Output: 2

var indexOf90 = marks.indexOf(90);
console.log("First occurrence of 90: " + indexOf90); //Output: -1

var lastIndexOf60 = marks.lastIndexOf(60);
console.log("Last occurrence of 60: " + lastIndexOf60); //Output: 9

var indexOf60SecondOccurrence = marks.indexOf(60, indexOf60 + 1);
console.log("Second occurrence of 60: " + indexOf60SecondOccurrence); //Output: 9