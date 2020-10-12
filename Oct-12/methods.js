//Object with methods
//Method: function inside object: generally used to manipulate data of properties
var person = {
    personName: "Scott",
    age: 20,
    birthDay: function() {
        this.age;
    }
};


console.log(person.age); //Output: 20
person.birthDay();
person.birthDay();
console.log(person.age); //Output: undefined