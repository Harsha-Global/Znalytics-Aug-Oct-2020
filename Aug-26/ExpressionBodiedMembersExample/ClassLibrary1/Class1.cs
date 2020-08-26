namespace College
{
    public class Student
    {
        //private field
        private string _studentName;

        //public property (expression bodied members)
        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }

        //method
        public int GetStudentNameLength() => _studentName.Length;

        //constructor
        public Student() => _studentName = "Harsha";
    }
}

