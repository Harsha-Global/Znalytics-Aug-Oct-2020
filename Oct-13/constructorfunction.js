//Constructor Function: It is a function that initializes properties and methods into a newly created object.

//Constructor function that initiliazes properties and methods of an object of Person.
function Person(personName, age) {

    //properties
    this.personName = personName;
    this.age = age;

    //methods
    this.birthDay = function() {
        this.age++;
    };
}

var p1 = new Person("Smith", 20);
console.log(p1);
// console.log(p1.personName);
// console.log(p1.age);
// p1.birthDay();
// console.log(p1.age);

var p2 = new Person("John", 25);
console.log(p2);