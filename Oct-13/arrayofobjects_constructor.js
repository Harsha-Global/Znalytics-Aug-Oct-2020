//Array of objects [or] Object arrays
//With Constructor Function

//Create constructor function
function Product(productID, productName, dateOfRelease) {
    this.productID = productID;
    this.productName = productName;
    this.dateOfRelease = dateOfRelease;
}

//Creating array of objects with constructor function
var products = [
    new Product(1, "Processor", new Date("2005-09-03")),
    new Product(2, "Laptop", new Date("2020-06-15")),
    new Product(3, "Keyboard", new Date("2019-08-02")),
    new Product(4, "Hardisk", new Date("2015-11-07")),
    new Product(5, "Mobile", new Date("2018-02-10"))
];

//console.log(products);

//filter
// var matchingProducts = products.filter(function(p) {
//     if (p.productID >= 2) {
//         return true; //this object should be added into the result
//     } else {
//         return false;
//     }
// });

//sort
//TO DO: Sort products based on Product Name using "sort" method.
var matchingProducts = products.sort(function(a, b) {
    var match;
    if (a.dateOfRelease < b.dateOfRelease)
        match = -1;
    else if (a.dateOfRelease > b.dateOfRelease)
        match = 1;
    else
        match = 0;

    return match;
});

//forEach: to print all products
matchingProducts.forEach(
    function(p) {
        console.log(`Product ID is ${p.productID}, Product Name is ${p.productName}, Date of Release is ${p.dateOfRelease.toLocaleDateString()}`);
    }
);