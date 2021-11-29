using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Security;
using BEL;
using BLL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PMA_Assignment_A_.HelperFunction;
using System.Web.Http;

namespace PMA_Assignment_A_.Controllers
{
    [EnableCors("*","*","*")]
    public class HomeController : ApiController
    {
        [Route("api/Student/Names")]
        [HttpGet]
        public void Add(UserSigninModel s)
        {
            LoginService.login(s);
        }

    }
}
