//employee net salary calculation using objects

//create an object with properties & methods
var employee = {
    employeeName: "Scott",
    deptNo: 10,
    basicSalary: 10000,
    netSalary: function() {
        let tax;
        if (this.deptNo == 10) {
            tax = this.basicSalary * 10 / 100;
        } else {
            tax = this.basicSalary = 12.5 / 100;
        }

        //calculate net salary (basic salary - tax)
        return this.basicSalary - tax;

    }
}

console.log(employee.employeeName);
console.log(employee.deptNo);
console.log(employee.basicSalary);
console.log(employee.netSalary());