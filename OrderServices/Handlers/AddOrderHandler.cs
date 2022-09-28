using MediatR;
using OrderServices.Commands;
using OrderServices.DataLayer;
using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServices.Handlers
{

    public class AddOrderHandler : IRequestHandler<AddOrderCommand, EcomOrders>
    {

        IOrderService orderService;

        public AddOrderHandler(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<EcomOrders> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(orderService.AddOrder(request.productId, request.customerId, request.quantity, request.price, request.shippmentAddress));
        }
    }
}
