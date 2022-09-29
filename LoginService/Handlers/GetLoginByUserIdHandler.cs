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
    public class GetLoginByUserIdHandler : IRequestHandler<GetLoginByUserIdQuery, EcomLogin>
    {
        ILoginService loginService;

        public GetLoginByUserIdHandler(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public async Task<EcomLogin> Handle(GetLoginByUserIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(loginService.GetLoginByUserId(request.userId));
        }
    }
}
