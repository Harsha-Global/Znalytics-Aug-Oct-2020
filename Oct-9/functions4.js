//default arguments: We will assign some default value for the parameter; if you don't supply value to that parameter, the default value will assigned into the parameter.
var calculateSimpleInterest = function(principleAmount, noOfYears, rateOfInterest = 4.0) {
    let si = (principleAmount * noOfYears * rateOfInterest) / 100;
    return si;
}

//calling the function
console.log(calculateSimpleInterest(10000, 4, 6.7)); //2680
console.log(calculateSimpleInterest(5000, 3)); //600