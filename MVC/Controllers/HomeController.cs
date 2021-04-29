using MVC.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        private readonly MVCContext db = new MVCContext();
        public ActionResult _Skills()
        {
            return PartialView("_Skills", db.Skills.ToList());
        }
        public ActionResult _Educations()
        {
            return PartialView("_Educations", db.Educations.ToList());
        }
        public ActionResult _Experiences()
        {
            return PartialView("_Experiences", db.Experiences.ToList());
        }
    }
}