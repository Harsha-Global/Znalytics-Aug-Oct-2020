//creating a function
var doWork = function() {
    //console.log(arguments); //contains the list of argument values that are supplied while calling the function
    console.log(arguments[0]);
    console.log(arguments[1]);
    console.log(arguments[2]);
    console.log(arguments[3]);
}

//calling the function with different arguments
doWork();
doWork(10, 20, 30);
doWork("Scott", 20, "scott@gmail.com", "9988888881");