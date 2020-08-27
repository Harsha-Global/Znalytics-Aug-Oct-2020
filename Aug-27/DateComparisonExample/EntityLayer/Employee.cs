using System;

namespace EntityLayer
{
    public class Employee
    {
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            set
            {
                //get the eligible date (present date - 18 years)
                DateTime eligibleDate = DateTime.Now;
                eligibleDate = eligibleDate.AddYears(-18);

                if (value < eligibleDate)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new EmployeeException("Date of birth should be less than " + eligibleDate.ToString("dd/M/yyyy"));
                }
            }
            get
            {
                return _dateOfBirth;
            }
        }
    }
}
