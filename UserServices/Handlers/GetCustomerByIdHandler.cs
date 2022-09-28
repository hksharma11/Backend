using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserServices.DataLayer;
using UserServices.Models;
using UserServices.Queries;

namespace UserServices.Handlers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, EcomCustomers>
    {

        IUserService userService;

        public GetCustomerByIdHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<EcomCustomers> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(userService.GetCustomerById(request.CustomerId));
        }
    }
}
