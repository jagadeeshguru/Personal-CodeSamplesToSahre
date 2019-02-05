using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ActivistTaskLocator.Models;

namespace ActivistTaskLocator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/SlideShow/"));
            List<Slider> files = new List<Slider>();
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                files.Add(new Slider
                {
                    title = fileName.Split('.')[0].ToString(),
                    src = "../SlideShow/" + fileName
                });
            }

            return View(files);
        }

        public ActionResult AddActivity()
        {
            return RedirectToAction("","Activity");
        }


        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }


        public ActionResult Chat()
        {
            return View();
        }

    }
}
