using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserServices.Command;
using UserServices.DataLayer;
using UserServices.Models;

namespace UserServices.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, EcomCustomers>
    {

        IUserService userService;

        public AddCustomerHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<EcomCustomers> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(userService.AddCustomer(request.customerName, request.customerAddress, request.customerPhone, request.customerEmail, request.loginId));
        }
    }
}
