using System;
using System.Runtime.Serialization;

namespace Company
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}

