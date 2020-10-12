//spread (...): takes all values from an array
var south = ["Tamil nadu", "Kerala", "Telangana"];
var north = ["Madhya Pradesh", "Maha rashtra", "Uttar Pradesh"];

//ES2015
var india = ["Andhra Pradesh", ...south, "New Delhi", ...north];
console.log(india);