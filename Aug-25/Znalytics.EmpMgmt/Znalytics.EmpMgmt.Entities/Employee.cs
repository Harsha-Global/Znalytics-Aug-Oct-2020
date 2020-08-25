using System;

namespace Znalytics.EmpMgmt.Entities
{
    //delegate type
    public delegate void MyDelegateType();

    //Publisher event
    public class Employee
    {
        //private field
        private string _employeeName;

        //auto-impl properties
        public int EmployeeID { get; set; }
        public string EmployeeName
        {
            set
            {
                _employeeName = value;
                if (_empNameChanged != null)
                {
                    _empNameChanged(); //raise event //automatically calls UpdateEmployeeName()
                }
            }
            get
            {
                return _employeeName;
            }
        }

        //private delegate
        private MyDelegateType _empNameChanged;

        //public event
        public event MyDelegateType EmpNameChanged
        {
            add
            {
                _empNameChanged = value;
            }
            remove
            {
                _empNameChanged += value;
            }
        }
    }
}

