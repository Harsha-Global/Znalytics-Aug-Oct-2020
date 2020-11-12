//step 1: Create a module
var app = angular.module("ecommerce-module", []); //[] indicates list of modules that you want to import

//step 2: Create a controller: navbar-controller
app.controller("navbar-controller", function ($scope) {
  //$scope is reference to model
  $scope.appTitle = "eCommerce";
  //automatically controller supplies model to view
});

//Create another controller: sidebar-controller
app.controller("sidebar-controller", function ($scope) {
  $scope.categories = ["Electronics", "Mobiles", "Home Appliances", "Fashion"];
});

//Create another controller: maincontent-controller
app.controller("maincontent-controller", [
  "$scope",
  "products-service",
  function ($scope, productsService) {
    $scope.pageTitle = "Products";

    $scope.products = productsService.getProducts();

    $scope.addQuantity = function (product) {
      product.quantity++;
    };

    $scope.removeQuantity = function (product) {
      if (product.quantity > 0) {
        product.quantity--;
      }
    };
  },
]);

//Create a filter in the ecommerce-module
app.filter("quantity", function () {
  return function (value) {
    if (value == 0) {
      return "Zero";
    } else {
      return value;
    }
  };
});

//Create a service in the ecommerce-module
app.service("products-service", function () {
  //getProducts: returns an array of products
  this.getProducts = function () {
    return [
      { id: 1, productName: "Bluetooth Head phones", price: 2300, quantity: 0 },
      { id: 2, productName: "iPhone", price: 44750, quantity: 0 },
      { id: 3, productName: "Keyboard", price: 250, quantity: 0 },
      { id: 4, productName: "Monitor", price: 9950, quantity: 0 },
      { id: 5, productName: "Camera", price: 16680, quantity: 0 },
    ];
  };
});
