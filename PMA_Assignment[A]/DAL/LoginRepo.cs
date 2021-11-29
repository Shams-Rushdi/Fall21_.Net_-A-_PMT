using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepo : IRepository<LoginUser, int>
    {
        static PMAEntities db;
        public LoginUser(PMAEntities db)
        {
            this.db = db;
        }

        public void Login(LoginUser e)
        {
            throw new NotImplementedException();
        }
    }
}
