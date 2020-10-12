//find: to get index of the first element that matches with given condition
var marks = [23, 25, 60, 34, 50, 92];

var firstPassedMarksIndex = marks.findIndex((m) => { return m >= 40; });
console.log(firstPassedMarksIndex); //2

var firstPassedMarksIndex2 = marks.findIndex((m) => { return m >= 95; });
console.log(firstPassedMarksIndex2); //-1