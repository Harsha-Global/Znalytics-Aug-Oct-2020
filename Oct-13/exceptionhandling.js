//Exception handling

//Code execution begins here
try {
    var a;
    var b = a / 3;

    if (isNaN(b)) {
        throw new Error("Please give valid input");
    }
    console.log(b);
} catch (err) {
    console.log(err.message);
} finally {
    console.log("Finally: Done.");
}