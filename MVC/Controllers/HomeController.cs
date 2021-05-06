using MVC.DAL;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

        public ActionResult _Files()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Files/"));

            List<FileModel> files = new List<FileModel>();
            foreach (string filePath in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }

            return PartialView(files);
        }

        public FileResult DownloadFile (string fileName)
        {
            string path = Server.MapPath("~/Files/") + fileName;

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
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
        public ActionResult _Person()
        {
            return PartialView("_Person", db.People.ToList());
        }
    }
}