using LoginService.Command;
using LoginService.Models;
using LoginService.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IMediator mediator;

        public LoginController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetLoginById/{loginId}")]
        public async Task<EcomLogin> GetLoginById(int loginId)
        {
            return await mediator.Send(new GetLoginByIdQuery { loginId=loginId});
        }


        [HttpPost("AddLogin/{password}/{token}/{datetime}/{loginRole}/{userId}")]
        public async Task<EcomLogin> AddLogin(string password, string token, DateTime datetime, string loginRole, string userId)
        {
            return await mediator.Send(new AddLoginCommand {password=password,token=token, datetime=datetime,loginRole=loginRole, UserId=userId });
        }


        [HttpGet("GetLoginByUserId/{userId}")]
        public async Task<EcomLogin> GetLoginByUserId(string userId)
        {
            return await mediator.Send(new GetLoginByUserIdQuery { userId=userId});
        }
    }
}
