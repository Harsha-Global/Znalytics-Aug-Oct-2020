public abstract class Person
{
    private string _personName;

    public string PersonName
    {
        get
        {
            return _personName;
        }
        set
        { 
            if (value.Length <= 30)
            {
                _personName = value;
            }
        }
    }

    //parent class's constructor that initializes only parent class's fields
    public Person(string PersonName)
    {
        this.PersonName = PersonName;
    }

    //parent class's method
    public virtual void Display(int x)
    {
        System.Console.WriteLine("Person name: " + PersonName);
    }

}
public class Employee : Person
{
    public int EmpID { get; set; }

    public Employee(string empName, int empID) : base(empName)
    {
        this.EmpID = empID;
    }

    //child class's method
    public override sealed void Display(int x)
    {
        base.Display(x); //calls Person.Display
        System.Console.WriteLine("Emp ID: " + EmpID);
    }
}
//public class Student : Person
//{
//    public int rollNo { get; set; }
//}

public class ContractBasedEmployee : Employee
{
    public ContractBasedEmployee(string empName, int empID) : base(empName, empID)
    {
    }

    public override void Display(int x)
    {
        base.Display(x); //calls Employee.Display
        System.Console.WriteLine("Other output here");
    }
}
