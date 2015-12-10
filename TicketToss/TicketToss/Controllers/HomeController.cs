using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketToss.Models;

namespace TicketToss.Controllers
{
    public class HomeController : Controller
    {

        DataGenerator d = new DataGenerator();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult MyTickets()
        {
            return View(d.Tickets);
        }
        public ActionResult CreateTickets()
        {
            ViewBag.Message = "Create Tickets page.";

            return View();
        }
        public ActionResult MyEvents()
        {
            return View(d.Events);
        }
    }
}
