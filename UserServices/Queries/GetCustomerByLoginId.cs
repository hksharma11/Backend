using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.Queries
{
    public class GetCustomerByLoginId : IRequest<EcomCustomers>
    {
        public int loginId { get; set; }
    }
}
