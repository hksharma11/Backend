using LoginService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Queries
{
    public class GetLoginByUserIdQuery : IRequest<EcomLogin>
    {
        public string userId { get; set; }
    }
}
