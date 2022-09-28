using LoginService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Command
{
    public class AddLoginCommand : IRequest<EcomLogin>
    {
        //string password, string token, DateTime datetime, string loginRole

        public string password { get; set; }
        public string token { get; set; }

        public DateTime datetime { get; set; }

        public string loginRole { get; set; }

        public string UserId { get; set; }
    }
}
