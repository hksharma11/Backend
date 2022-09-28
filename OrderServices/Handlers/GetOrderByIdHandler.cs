using MediatR;
using OrderServices.DataLayer;
using OrderServices.Models;
using OrderServices.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServices.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, EcomOrders>
    {

        IOrderService orderService;

        public GetOrderByIdHandler(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<EcomOrders> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(orderService.GerOrderById(request.orderId));
        }
    }
}
