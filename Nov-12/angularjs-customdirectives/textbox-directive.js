//Create a directive called "textbox"
app.directive("textbox", [
  function () {
    var mydirective = {};

    //specify model of directive
    mydirective.scope = { pname: "=name" };

    //specify restriction (as Element or as Attribute)
    mydirective.restrict = "E"; //says that we can use the directive as an element only; but not as an attribute

    //the "compile" function executes as soon as the directive is called
    mydirective.compile = function (element, attributes) {
      //the "link" function executes as soon as the directive is called
      var linkFunction = function ($scope, element, attributes) {
        console.log("this is link function");

        //element = represents the <textbox> tag
        //attributes = represents a set of attributes of <textbox> tag
        //$scope = represents model of <textbox> tag

        element.html(`<input type="text" value="${$scope.pname}">`);

        //styles
        element.find("input").css("background-color", "#f5f6f7");
        element.find("input").css("border", "1px solid grey");
        element.find("input").css("border-radius", "2px");
      };

      return linkFunction;
    };
    return mydirective;
  },
]);
