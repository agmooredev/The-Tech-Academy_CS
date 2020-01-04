using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
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

        public ActionResult Instructors()
        {


            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {

                Id = 001,
                FirstName = "Jordan",
                LastName = "Belfort"
                },

                new Instructor
                {
                Id = 001,
                FirstName = "Jordan",
                LastName = "Belfort"
                },

                new Instructor
                {

                Id = 001,
                FirstName = "Jordan",
                LastName = "Belfort"
                },



            }

            }

        }
    }
