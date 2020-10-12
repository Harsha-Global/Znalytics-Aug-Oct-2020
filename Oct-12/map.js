//map: executes the specified function and adds the returned value into a new array; and finally returns the new array.
//Acts as a conversion function that converts elements of the array to another format
var numbers = [1, 5, 8, 2, 4, 78];

var newArray = numbers.map(
    function(m) {
        var word;
        switch (m) {
            case 1:
                word = "One";
                break;
            case 2:
                word = "Two";
                break;
            case 3:
                word = "Three";
                break;
            case 4:
                word = "Four";
                break;
            case 5:
                word = "Five";
                break;
            case 6:
                word = "Six";
                break;
            case 7:
                word = "Seven";
                break;
            case 8:
                word = "Eight";
                break;
            case 9:
                word = "Nine";
                break;
            case 0:
                word = "Zero";
                break;
        }

        return word;
    }
);

console.log(newArray); //Output: [ "One", "Five", "Eight", "Two", "Four", undefined ]