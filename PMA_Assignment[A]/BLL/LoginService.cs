using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginService
    {
        public static void login(LoginUser s)
        {
            var lg = (from udb in db.LoginUser
                      where udb.Name == Name && udb.Password == Password
                      select udb).FirstOrDefault();

            return lg;
        }
    }
}
