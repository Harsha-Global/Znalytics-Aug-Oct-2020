using System;

namespace Company
{
    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }

    public class Customer: IEquatable<Customer>, IComparable<Customer>
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


        //public int CompareTo(Customer other)
        //{
        //    if (this.CustomerName[0] == other.CustomerName[0])
        //    {
        //        return 0; //"this" object and parameter object occur in the same position (unchanged).
        //    }
        //    else if (this.CustomerName[0] > other.CustomerName[0])
        //    {
        //        return 1; //parameter object comes first; "this" object comes next.
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}



        public int CompareTo(Customer other)
        {
            int compare;
            //CustomerType
            compare = this.CustomerType.CompareTo(other.CustomerType);
            
            if (compare == 0)
            {
                //Age
                compare = this.Age.CompareTo(other.Age);
            }

            if (compare == 0)
            {
                //CustomerName
                compare = this.CustomerName.CompareTo(other.CustomerName);
            }

            compare = compare * -1;

            return compare;
        }
    }
}

