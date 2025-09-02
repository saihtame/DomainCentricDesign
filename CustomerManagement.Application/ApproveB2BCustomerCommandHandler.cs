using CustomerManagement.Domain;
using CustomerManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Application
{
    public class ApproveB2BCustomerCommandHandler
    {
        InMemoryB2BCustomerRepo customerRepo = new InMemoryB2BCustomerRepo();

        public void Handle(ApproveB2BCustomerCommand command)
        {
            var customer = customerRepo.GetById(command.Id);

            if (customer == null)
            {
                return;
            }

            customer.Approved = true;
        }
    }
}
