using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel.Models.Classlar;

namespace Travel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        SeyaContext db = new SeyaContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var bilgiler = db.Admins.FirstOrDefault(x => x.KullaniciAdi == admin.KullaniciAdi && x.Password == admin.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("index", "admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login", "login");
        }
    }
}