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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            int Num;
            string ID;
            string uname = frm.Get("userName");
            string pass = frm.Get("password");

            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                 Num = db.User.Count(w => w.UName== uname && w.Pass == pass);
                 ID =  db.User.Where(w =>  w.UName == uname && w.Pass == pass).Select(w=> w.UserTypeID).ToString();

            }

            if (Num > 0)
            {
                Session["name"] = uname;
                Session["ID"] = ID;
                return RedirectToAction("UyeListesi", "Home");
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