//sort
var numbers = [24, 95, 80, 12, 45];

numbers.sort(

    function(a, b) {
        let temp;
        if (a < b) {
            temp = -1; //negative
        } else if (a > b) {
            temp = 1; //positive
        } else
            temp = 0; //unchanged

        return temp;
    }

);

numbers.reverse();

console.log(numbers);