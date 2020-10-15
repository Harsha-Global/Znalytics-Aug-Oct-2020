//Goal: To send request + Get response
var loadEmployees = function() {
    var xhr = new XMLHttpRequest(); //create an object based on XMLHttpRequest constructor function

    xhr.open("GET", "http://localhost:3000/employees"); //initializing the request.  open(method, url)

    xhr.send(); //actual request will be sent

    //the callback function will be executed as soon as response received
    xhr.addEventListener("load", function() {
        var employees = JSON.parse(xhr.responseText); //by default JSON format. JSON.parse() method converts "JSON" into "object array"

        //console.log(employees);

        document.querySelector("#loading").style.display = "none"; //hide the icon

        employees.forEach(function(e) {
            var row = `<tr> <td>${e.id}</td> <td>${e.empName}</td> <td>${e.email}</td> </tr>`;

            //console.log(row);

            document.querySelector("#employees tbody").innerHTML += row;
        });
    });
};

loadEmployees();