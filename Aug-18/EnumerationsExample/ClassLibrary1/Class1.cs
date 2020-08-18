namespace College
{
    public enum ListOfBranches: long
    {
        CSE= 10, IT = 20, Mech = 3000000000000000, EEE = 40, ECE = 50
    }
    public class Student
    {
        public string StudentName { get; set; }
        public string Email { get; set; }
        public ListOfBranches Branch { get; set; }
    }
}