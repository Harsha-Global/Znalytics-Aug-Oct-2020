//find: to get first element that matches with given condition
var marks = [23, 78, 60, 34, 50, 92];

var firstPassedMarks = marks.find((m) => { return m >= 40; });
console.log(firstPassedMarks); //Output: 78

var firstPassedMarks2 = marks.find((m) => { return m >= 95; });
console.log(firstPassedMarks2); //Output: undefined