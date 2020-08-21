using Company;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Company
{
    public class CustomersCollection : IEnumerable
    {
        List<Customer> _customers;

        public CustomersCollection()
        {
            _customers = new List<Customer>() {
                new Customer() { CustomerID = 101, CustomerName= "Anna", Age = 20, CustomerType = TypeOfCustomer.RegularCustomer },
                new Customer() { CustomerID = 102, CustomerName= "Bob", Age = 35, CustomerType = TypeOfCustomer.VIPCustomer },
                new Customer() { CustomerID = 103, CustomerName= "Smith", Age = 24, CustomerType = TypeOfCustomer.RegularCustomer },
                new Customer() { CustomerID = 104, CustomerName= "John", Age = 20, CustomerType = TypeOfCustomer.VIPCustomer },
                new Customer() { CustomerID = 105, CustomerName= "Sarath", Age = 20, CustomerType = TypeOfCustomer.RegularCustomer },
                new Customer() { CustomerID = 106, CustomerName= "Ford", Age = 20, CustomerType = TypeOfCustomer.VIPCustomer },
                new Customer() { CustomerID = 107, CustomerName= "David", Age = 32, CustomerType = TypeOfCustomer.RegularCustomer },
            };
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                yield return _customers[i];
            }
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> FindAll(Predicate<Customer> predicate)
        {
            return _customers.FindAll(predicate);
        }

        public bool Contains(Customer customer)
        {
            return _customers.Contains(customer);
        }

        public void Sort()
        {
            _customers.Sort();
        }

        public void Sort(IComparer<Customer> comparer)
        {
            _customers.Sort(comparer);
        }
    }
}
