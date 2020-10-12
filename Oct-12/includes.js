//includes: to determine whether the specified element is found in the array.
//returns true, if the specified element is found in the array
//returns false, if the specified element is not found in the array

var marks = [23, 78, 60, 34, 50, 92];

var isAtleastOneSubjectPassed = marks.includes(78);
console.log(isAtleastOneSubjectPassed); //Output: true

var isAtleastOneSubjectPassed2 = marks.includes(95);
console.log(isAtleastOneSubjectPassed2); //Output: false