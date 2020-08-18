using System;

namespace ClassLibrary1
{
    public readonly struct Month
    {
        //private fields
        private readonly int _monthNumber;
        private readonly string _monthName;

        //constructor
        public Month(int monthNumber, string monthName)
        {
            _monthNumber = monthNumber;
            _monthName = monthName;
        }

        //public properties
        public int MonthNumber
        {
            get
            {
                return _monthNumber;
            }
        }

        public string MonthName
        {
            get
            {
                return _monthName;
            }
        }
    }
}

