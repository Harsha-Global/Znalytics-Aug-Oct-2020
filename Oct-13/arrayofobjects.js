//Array of objects [or] Object arrays
//With Object literals
var products = [{
        productID: 1,
        productName: "Laptop",
        dateOfRelease: new Date("2020-06-15")
    },

    { productID: 2, productName: "Keyboard", dateOfRelease: new Date("2019-08-02") },

    { productID: 3, productName: "Mobile", dateOfRelease: new Date("2018-02-10") }
];

//console.log(products);

//filter
var matchingProducts = products.filter(function(p) {
    if (p.productID >= 2) {
        return true; //this object should be added into the result
    } else {
        return false;
    }
});

//forEach: to print all products
matchingProducts.forEach(
    function(p) {
        console.log(`Product ID is ${p.productID}, Product Name is ${p.productName}, Date of Release is ${p.dateOfRelease.toLocaleDateString()}`);
    }
);