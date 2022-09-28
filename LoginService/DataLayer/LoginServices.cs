using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.DataLayer
{
    public class LoginServices : ILoginService
    {

        EcomContext db;

        public LoginServices(EcomContext db)
        {
            this.db = db;
        }

       

        public EcomLogin AddLogin(string password, string token, DateTime datetime, string loginRole, string userId)
        {
            var log = new EcomLogin()
            {
                Password = password,
                Token = token,
                DateTimeStamp = datetime,
                LoginRole = loginRole,
                UserId=userId
                
            };
            db.EcomLogin.Add(log);
            db.SaveChanges();
            return log;
        }

        public EcomLogin GetLoginById(int loginId)
        {
            return db.EcomLogin.SingleOrDefault(x => x.LoginId == loginId);
        }
    }
}
