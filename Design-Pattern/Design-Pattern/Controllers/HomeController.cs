using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Design_Pattern.Models.Singleton;

namespace Design_Pattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Singleton.getInstance().userID = "180001";
            Singleton.getInstance().userPwd = "Pwd18001";
            Singleton.getInstance().userName = "User 18001";
            string userID = Singleton.getInstance().userID;
            string userPwd = Singleton.getInstance().userPwd;
            string userName = Singleton.getInstance().userName;

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. <br />User ID : " 
                + userID + " <br />User Pwd : " + userPwd + " <br />User Name : " + userName;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
