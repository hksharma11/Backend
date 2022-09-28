using MediatR;
using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Commands
{
    public class AddOrderCommand : IRequest<EcomOrders>
    {
        //int productId, int customerId, int quantity, decimal price, string shippment_address
        public int productId { get; set; }

        public int customerId { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public string shippmentAddress { get; set; }
    }
}
