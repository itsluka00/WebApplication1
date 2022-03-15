using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentiController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Pocetna o studentima";
            ViewBag.Fakultet = "Medimursko veleuciliste";
            return View();
        }

        public ActionResult Popis()
        {
            StudentiDB studentDB = new StudentiDB();
            return View(studentDB);
        }

        public ActionResult Detalji(int? id)
        {
            if (!id.HasValue)
            {
                RedirectToAction("Popis");
            }

            StudentiDB studentDB = new StudentiDB();
            Student student = studentDB.vratiListu().FirstOrDefault(x => x.ID == id);

            if (student != null)
            {
                RedirectToAction("Popis");
            }
            return View(student);
        }
    }
}