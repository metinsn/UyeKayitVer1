using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UyeKayitVer1.Entitiy.Context;
using UyeKayitVer1.Entitiy.Viewmodel;

namespace UyeKayitVer1.WEB.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (Session["name"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            int sayi;
            string uname = frm.Get("userName");
            string pass = frm.Get("password");

            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                 sayi = db.User.Count(w => w.UName== uname && w.Pass == pass);

            }

            if (sayi>0)
            {
                Session["name"] = "Metin";
                Session["pass"] = "1";
                return RedirectToAction("UyeKayit", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Hatalı Bilgiler!";
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}