//Create a controller called my-controller in my-module
app.controller("my-controller", [
  "$scope",
  function ($scope) {
    //$scope = model
    $scope.personName = "Scott";
  },
]);
