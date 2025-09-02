using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Domain
{
    public class B2BCustomer
    {
        public int Id { get; set; }
        public B2BDiscount? DiscountPolicy { get; set; }
        public bool Approved { get; set; } 


        public B2BCustomer(int id)
        {
            Id = id;
        }
    }
}
