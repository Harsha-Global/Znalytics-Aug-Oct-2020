using System;

interface Interface1
{
    void Method1(int x, int y);
}

interface Interface2
{
    void Method1(int x, int y);
}

class ChildClass : Interface1, Interface2
{
    void Interface1.Method1(int x, int y)
    {
        System.Console.WriteLine("Interface1.Method1");
    }
    void Interface2.Method1(int x, int y)
    {
        System.Console.WriteLine("Interface2.Method1");
    }

    public void CallBothMethods()
    {
        Interface1 i1 = this;
        i1.Method1(10, 5);

        Interface2 i2 = this;
        i2.Method1(10, 5);
    }
}

class Program
{
    static void Main()
    {
        Interface1 i1;
        i1 = new ChildClass();
        i1.Method1(10, 5); //Output: Interface1.Method1

        Interface2 i2;
        i2 = new ChildClass();
        i2.Method1(10, 5); //Output: Interface2.Method1

        //ChildClass cc = new ChildClass();
        //cc.CallBothMethods(); //Both methods will be called
        Console.ReadKey();
    }
}
