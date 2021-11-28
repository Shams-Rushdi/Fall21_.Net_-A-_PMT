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
using PMA_Assignment_A_.HelperFunction;

namespace PMA_Assignment_A_.Controllers
{
    [EnableCors("*","*","*")]

    public class HomeController : ApiController
    {
        public JsonResult Login(LoginUser u)
        {
            if (ModelState.IsValid)
            {
                PMAEntities db = new PMAEntities();
                var ur = UserHelper.auth(u.UserName, u.Password);

                if (ur != null)
                {
                    //Session["Id"] = u.Id;
                    //FormsAuthentication.SetAuthCookie(ur.Id, true);
                    //return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ViewBag.error = "Phone or Password is Invalid";
                }
            }
            

        }
    }
}
