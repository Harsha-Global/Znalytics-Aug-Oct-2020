//map: One-to-One
//flatMap: One-to-Many

//flatMap: executes the specified function and adds the returned array elements into a new array; and finally returns the new array.
var ages = [18, 24, 32, 7, 45];

var newArray = ages.flatMap(
    function(m) {
        return [m, m + 1, m - 1];
    }
);

console.log(newArray);
/*
[
  18, 19, 17, 24, 25, 23,
  32, 33, 31,  7,  8,  6,
  45, 46, 44
]
*/