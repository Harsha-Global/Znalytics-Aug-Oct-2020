//filter: to get all the elements that match with given condition
var marks = [78, 60, 34, 50, 92, 23];

var passedMarks = marks.filter(
    (m) => { return m >= 40; }
);
console.log(marks);
console.log(passedMarks);