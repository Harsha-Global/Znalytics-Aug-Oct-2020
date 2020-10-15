//Date methods

//1. new Date()
var a = new Date();
console.log(a);

//2. Date.now()
var b = Date.now();
console.log(b); //No. of milliseconds since 1970-01-01 12:00 am (UNIX date)

//3. new Date("yyyy-MM-dd HH:mm:ss tt")
var c = new Date("2015-05-18 10:00 am");
console.log(c); //2015-05-18T04:30:00.000Z

//4. toLocaleDateString: Returns MM/dd/yyyy
var c = new Date();
console.log(c.toLocaleDateString()); //10/13/2020

//5. toLocaleTimeString: Returns h:mm:ss tt
var c = new Date();
console.log(c.toLocaleTimeString()); //1:03:08 PM

//6. getTime()
console.log(a.getTime()); //No. of milliseconds since 1970-01-01 12:00 am (UNIX date)
console.log(a.getDay()); //Day of week (0-6); Sunday is 0
console.log(a.getDate());
console.log(a.getMonth() + 1); //0 to 11
console.log(a.getFullYear());
console.log(a.getHours()); //0 to 23
console.log(a.getMinutes());
console.log(a.getSeconds());
console.log(a.getMilliseconds());