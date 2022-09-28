using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.Command
{
    public class AddCustomerCommand : IRequest<EcomCustomers>
    {
        
        public string customerName { get; set; }

        public string customerAddress { get; set; }

        public string customerPhone { get; set; }

        public string customerEmail { get; set; }

        public int loginId { get; set; }
    }
}
