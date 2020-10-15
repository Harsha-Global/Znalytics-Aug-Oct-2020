//String methods

//1. toUpperCase()
var s = "HelloWorld";
var a = s.toUpperCase(); //Converts the string into uppercase
console.log(a); //HELLOWORLD

//2. toLowerCase()
s = "HelloWorld";
var b = s.toLowerCase(); //Converts the string into lower case
console.log(b); //helloworld

//3. length
s = "HelloWorld";
var c = s.length; //Returns count of characters (alphabets / special characters / spaces / digts)
console.log(c); //10

//4. substr(startIndex, length)
s = "HelloWorld";
var d = s.substr(2, 3); //Returns the string starts from the startIndex; up to specified count of characters
console.log(d); //llo

//5. indexOf(string, startIndex)
s = "HelloWorld";
var e = s.indexOf("l"); //Returns the index of first occurrence; otherwise returns -1
console.log(e); //Output: 2

//6. split()
s = "hello how are you";
var f = s.split(" "); //It creates a new value for each occurrence of the specified character; and forms a new array with those values
console.log(f); //Output: [ "hello", "how", "are", "you"]

//7. trim()
s = "      hello how are you        ";
var g = s.trim(); //It removes spaces at L.H.S and R.H.S
console.log(g); //Output: "hello how are you"

//8. startsWith()
s = "www.website.com";
var h = s.startsWith("www"); //It returns true, if the string begins with specified string
console.log(h); //Output: true

//9. endsWith()
s = "www.website.com";
var i = s.endsWith("com"); //It returns true, if the string ends with specified string
console.log(i); //Output: true

//10. Checking count of alphabets of a string
var getCountOfAlphabets = function(s) {
    let c = 0;
    for (let i = 0; i < s.length; i++) {
        if (
            (s.charCodeAt(i) >= 65 && s.charCodeAt(i) <= 90) ||
            (s.charCodeAt(i) >= 97 && s.charCodeAt(i) <= 122))
            c++;
    }
    return c;
};

console.log(getCountOfAlphabets("abc1$#@")); //Output: 3
console.log(getCountOfAlphabets("dfgj059jKLDFJ0942ijg")); //Output: 13

//A-Z = 65 to 90
//a-z = 97 to 122
//0-9 = 48 to 57