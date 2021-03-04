using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCDemo.Models;

namespace ASPMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {

        ReleaseManagementContext context = new ReleaseManagementContext();
        // GET: Employee
        public ActionResult Index()
        {
            var data = context.LoginDetails.ToList();
            return View(data);
        }

        public ActionResult Register()
        {
            return View();
        }

        
        [HttpPost]
        public string Register(LoginDetails loginDetails)
        {
            try
            {
                context.LoginDetails.Add(loginDetails);
                context.SaveChanges();
                
                return "User Added Successfully" ;
            }
            catch(Exception e)
            {
                return "Failed\nException Message : "+e.Message ;
                
            }
        }

        
        public ActionResult Edit(int? employeeId)
        {
            var data = context.LoginDetails.Where(x => x.UserID == employeeId).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(int id, LoginDetails model)
        {
            var data = context.LoginDetails.FirstOrDefault(x => x.UserID == id);
  
            if (data != null)
            {
                
                data.Password = model.Password;
                data.UserRole = model.UserRole;
               
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View();

        }

        public ViewResult Delete(int id)
        {
            var data = context.LoginDetails.FirstOrDefault(x => x.UserID == id);
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            var data = context.LoginDetails.FirstOrDefault(x => x.UserID == id);
            if (data != null)
            {
                context.LoginDetails.Remove(data);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}