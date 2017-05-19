using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            string uname = frm.Get("userName");
            string pass = frm.Get("password");

            if (uname == "metin" && pass == "1")
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
            Session["name"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}