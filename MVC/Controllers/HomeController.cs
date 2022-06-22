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
        //Visar Index sidan.
        public ActionResult Index()
        {
            return View();
        }

        //En partial view med en funktion som letar efter filer i mappen "files" enligt attributen i modellen FileModel.
        //Implementerad i /Views/Shared/_Footer
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

        // Funktion som låter användaren ladda ner mitt CV från hemsidan.
        public FileResult DownloadFile (string fileName)
        {
            string path = Server.MapPath("~/Files/") + fileName;

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }

        // Partial views som som hämtar information från respektive tabell i databasen och skickar datan till respektive view.
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