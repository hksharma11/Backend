using LoginService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Queries
{
    public class GetLoginByIdQuery : IRequest<EcomLogin>
    {
        public int loginId { get; set; }
    }
}
