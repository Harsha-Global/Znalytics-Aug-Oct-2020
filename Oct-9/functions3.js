//recursion: factorial(5) - a function calls itself
var factorial = function(n) {
    if (n == 1) {
        return 1;
    } else //if n is greater than 1
    {
        return n * factorial(n - 1); //Ex:  5 * factorial(4)
    }
}

//calling the function
let fact = factorial(5);
console.log("Factorial of 5: " + fact);