public class Person
{
    private string PersonName { get; set; }

    //parent class's constructor that initializes only parent class's fields
    public Person(string PersonName)
    {
        this.PersonName = PersonName;
    }
}
public class Employee : Person
{
    public int EmpID { get; set; }

    public void Method2()
    {
        base.Method1();
    }
}
public class Student : Person
{
    public int rollNo { get; set; }
}

