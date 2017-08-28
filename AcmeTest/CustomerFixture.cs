using System;
using NUnit.Framework;

namespace AcmeTest
{
    [TestFixture]
    public class CustomerFixture
    {
        private void ShowCustomer(Customer cust)
        {
            Console.WriteLine("id = {0}", cust.CustomerId);
            Console.WriteLine("first = {0}", cust.FirstName);
            Console.WriteLine("last = {0}", cust.LastName);
            Console.WriteLine("email = {0}", cust.EmailAddress);
        }
        [Test]
        private void OneCustomer()
        {
            Customer cust = new Customer("Dog", "Taranova", "dog@crime.com");
            ShowCustomer(cust);
        }
    }
}
