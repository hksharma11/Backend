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
    public class GetCustomerByLoginIdHandler : IRequestHandler<GetCustomerByLoginId, EcomCustomers>
    {

        IUserService userService;

        public GetCustomerByLoginIdHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<EcomCustomers> Handle(GetCustomerByLoginId request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(userService.GetCustomerByLoginId(request.loginId));
        }
    }
}
