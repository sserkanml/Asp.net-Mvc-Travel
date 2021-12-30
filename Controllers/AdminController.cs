using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Classlar;

namespace Travel.Controllers
{
    public class AdminController : Controller
    {
        SeyaContext db = new SeyaContext();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {

            return View(db.Blogs.ToList());
        }
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult BlogGetir(int id)
        {
            var blog = db.Blogs.Find(id);

            return View("BlogGetir",blog);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg = db.Blogs.Find(blog.Id);
            blg.Aciklama = blog.Aciklama;
            blg.Baslik = blog.Baslik;
            db.SaveChanges();
              
            return RedirectToAction("index");
        }
    }
}