using LoginService.Command;
using LoginService.DataLayer;
using LoginService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LoginService.Handlers
{
    public class AddLoginHandler : IRequestHandler<AddLoginCommand, EcomLogin>
    {

        ILoginService loginService;

        public AddLoginHandler(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public async Task<EcomLogin> Handle(AddLoginCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(loginService.AddLogin(request.password, request.token, request.datetime, request.loginRole, request.UserId));
        }
    }
}
