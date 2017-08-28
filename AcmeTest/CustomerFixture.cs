using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Customer(string first, string last, string email)
        {
            CustomerId = nextCustId++;
            FirstName = first;
            LastName = last;
            EmailAddress = email;
        }
    }
}
