//Or Operator ( || ): If the value is null or undefined or 0 or "" or false; then it returns the R.H.S. operand; otherwise it returns the actual value of L.H.S. operand
var personName = "scott";
console.log(personName || "No name");

//Null Coalescing Operator: If the value is null or undefined; then it returns the R.H.S. operand; otherwise it returns the actual value of L.H.S. operand
//var result = personName ?? "No name";
//console.log(result);

//Conditional operator
console.log((personName) ? personName.toUpperCase() : "No name");