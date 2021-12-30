using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Classlar;

namespace Travel.Controllers
{

    public class HomeController : Controller
    {
        SeyaContext db = new SeyaContext();
        
        public ActionResult Index()
        {
            

            return View(db.Blogs.ToList());
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
        public ActionResult Blog()
        {
            var blog = db.Blogs.ToList();
            return View(blog);

        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = db.Blogs.Where(i => i.Id == id).ToList();
            by.Deger2 = db.Yorumlars.ToList();
            return View(by);
        }
    }
}