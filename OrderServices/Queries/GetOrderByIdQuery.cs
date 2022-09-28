using MediatR;
using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Queries
{
    public class GetOrderByIdQuery : IRequest<EcomOrders>
    {
        public int orderId { get; set; }
    }
}
