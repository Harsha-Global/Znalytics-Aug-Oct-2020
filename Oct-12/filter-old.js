//filter: using for loop
var marks = [78, 60, 34, 50, 92, 23];
var passedMarks = [];

for (let i = 0; i < marks.length; i++) {
    if (marks[i] >= 40) {
        passedMarks.push(marks[i])
    }
}

console.log(passedMarks);