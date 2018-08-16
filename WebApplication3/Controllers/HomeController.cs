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
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult AddUser(UserInfo newUser)
        {

            //add validation!

            if (ModelState.IsValid)
            {
                //send the data to DB



                //confirmation or send to index page etc. 



                //     ViewData["ConfMessage"] = "Thanks" + newUser.FirstName; //regular dictionary (older style) does the same thing as next line)

                ViewBag.ConfMessage = "Thanks for signing up " + newUser.FirstName;   //dynamic dictionary   .ConfMessage is a new variable here. 
                                                                       // viewbag data only goes one way from controller to view only.     controller -----> view     
                                                                       //viewbag is a dynamic object. 



                //view should have a different name, because it only shows the data. 

                return View("Confirm");
            }


            else
            {
                return View("Error");
            }
            //changed name to confirm to be more specific for other developers.
        }
    }
}