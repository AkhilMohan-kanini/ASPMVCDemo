using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCDemo.Models;

namespace ASPMVCDemo.Controllers
{
    public class LoginController : Controller
    {

        ReleaseManagementContext context = new ReleaseManagementContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public String Index(LoginDetails loginDetails)
        {
            var data = context.LoginDetails.FirstOrDefault(x => x.UserID == loginDetails.UserID);

            if (data != null)
            {

                if (data.Password == loginDetails.Password)
                {
                    return "Welcome " + data.UserRole;
                }
                else
                {
                    return "User ID or Password Incorrect";
                }



            }
            else
                return "Login Failed";
        }

    }
}