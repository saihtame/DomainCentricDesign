using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Domain
{
    public class ApproveB2BCustomerCommand
    {
        public int Id { get; set; }

        public ApproveB2BCustomerCommand(int customerId)
        {
            Id = customerId;
        }
    }
}
