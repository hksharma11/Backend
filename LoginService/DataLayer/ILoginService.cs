using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.DataLayer
{
    public interface ILoginService
    {
        EcomLogin GetLoginById(int loginId);

        EcomLogin AddLogin(string password, string token, DateTime datetime, string loginRole, string userId);

        EcomLogin GetLoginByUserId(string userId);
    }
}
