using System;
using System.Collections.Generic;

namespace Company
{
    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }

    public class Customer: IEquatable<Customer>
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

        

        public bool Equals(Customer other)
        {
            if (this.CustomerID == other.CustomerID && this.CustomerName == other.CustomerName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            int compare;
            //CustomerType
            compare = x.CustomerType.CompareTo(y.CustomerType);

            if (compare == 0)
            {
                //Age
                compare = x.Age.CompareTo(y.Age);
            }

            if (compare == 0)
            {
                //CustomerName
                compare = x.CustomerName.CompareTo(y.CustomerName);
            }

            //compare = compare * -1;

            return compare;
        }
    }
}

