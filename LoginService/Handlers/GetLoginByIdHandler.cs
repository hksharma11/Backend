using LoginService.DataLayer;
using LoginService.Models;
using LoginService.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LoginService.Handlers
{
    public class GetLoginByIdHandler : IRequestHandler<GetLoginByIdQuery, EcomLogin>
    {

        ILoginService loginService;

        public GetLoginByIdHandler(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public async Task<EcomLogin> Handle(GetLoginByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(loginService.GetLoginById(request.loginId));
        }
    }
}
