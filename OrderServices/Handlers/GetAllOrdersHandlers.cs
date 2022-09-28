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
    public class GetAllOrdersHandlers : IRequestHandler<GetAllOrdersQuery, List<EcomOrders>>
    {
        IOrderService orderService;

        public GetAllOrdersHandlers(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<List<EcomOrders>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(orderService.GetAllOrders());
        }
    }
}
