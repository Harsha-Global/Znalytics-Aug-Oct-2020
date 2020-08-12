class Program
{
    static void Main()
    {
        //static field
        Student.group = "ECE";

        //create reference variable
        Student s1, s2, s3;

        //create object
        s1 = new Student(123);
        s2 = new Student(345);
        s3 = new Student(788);

        //initialize values
        //s1.rollNo = 123;
        s1.studentName = "Smith";
        //s2.rollNo = 345;
        s2.studentName = "Allen";
        //s3.rollNo = 34534;
        s3.studentName = "Scott";

        System.Console.WriteLine(s2.rollNo); //Output: 0
        System.Console.WriteLine(Student.group); //Output: ECE
        Student.group = "Mech";
        System.Console.WriteLine(Student.group); //Output: Mech

        const string collegeName = "XYZ College of Tech"; //local constant

        System.Console.WriteLine(Student.collegeName); //Output: ABC College of Tech

        System.Console.ReadKey();
    }
}

