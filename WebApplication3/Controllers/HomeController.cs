using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.firstName = "John";
            user.lastName = "Murray";
            user.Age = 44;
            return View(user);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello";

            return View();
        }

        public ActionResult Contact(int id )
        {
            ViewBag.Message = id=0;

            return View();
        }
    }
}