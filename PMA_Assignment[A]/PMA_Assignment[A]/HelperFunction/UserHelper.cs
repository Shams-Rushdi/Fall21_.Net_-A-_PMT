using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL;

namespace PMA_Assignment_A_.HelperFunction
{
    public class UserHelper
    {
        static PMAEntities db;
        static UserHelper()
        {
            db = new PMAEntities();
        }
        public static LoginModel auth(string UserName, string Password)
        {
            var entity = (from e in db.LoginUsers
                          where e.UserName == e.UserName & e.Password == e.Password
                          select e).FirstOrDefault();
            return entity;
        }
    }
}