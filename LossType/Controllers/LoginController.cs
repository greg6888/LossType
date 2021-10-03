using LossType.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LossType.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            Login login = new Login();
            return View(login);
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            UserList users = new UserList();
            bool checkUser=users.CheckUsers(login.userName, login.Password);
            if (checkUser)
                return RedirectToAction("DisplayLossType");
            else
                return View(login);
        }

        public ActionResult DisplayLossType()
        {
            LosstypeList losstypeList = new LosstypeList();
            var losstypes=losstypeList.GetLossType();
            return View(losstypes);
        }
    }
}