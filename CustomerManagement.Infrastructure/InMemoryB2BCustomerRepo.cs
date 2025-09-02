using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.Domain;

namespace CustomerManagement.Infrastructure
{
    public class InMemoryB2BCustomerRepo
    {
        public List<B2BCustomer> B2BCustomers = new List<B2BCustomer>();


        public InMemoryB2BCustomerRepo()
        {
            B2BCustomers.Add(new B2BCustomer(1));
            B2BCustomers.Add(new B2BCustomer(2));
            B2BCustomers.Add(new B2BCustomer(3));
        }

        public B2BCustomer? GetById(int id)
        {
            return B2BCustomers.FirstOrDefault(c => c.Id == id);
        }
    }
}
