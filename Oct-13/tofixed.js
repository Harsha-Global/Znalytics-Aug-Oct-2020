//toFixed()
var n = 9800.378434245;
console.log(n.toFixed(2));

//isNaN
var m = parseInt("100");
console.log(m); //NaN
if (isNaN(m)) {
    console.log("It is NaN");
} else {
    console.log("It is a number");
}