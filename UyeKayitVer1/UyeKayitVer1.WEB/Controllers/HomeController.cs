using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UyeKayitVer1.DAL.Depolar;
using UyeKayitVer1.Entitiy.Models;
using UyeKayitVer1.Entitiy.Viewmodel;

namespace UyeKayitVer1.WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult UyeKayit()
        {
            var deger = PTypeDepo.GetAll();
            return View(deger);
        }
        
        [HttpPost]
        public ActionResult UyeKayit(Person model)
        {
            PersonDepo.Add(model);
            return RedirectToAction("UyeListesi");
        }

        public ActionResult UyeListesi()
        {
            var deger = PersonDepo.GetAllVM();
            return View(deger);
        }

        public ActionResult UyeGörev()
        {
            var deger = PTypeDepo.GetAll();

            return View(deger);
        }
        [HttpPost]
        public ActionResult UyeGörev(PType model)
        {
            PTypeDepo.Add(model);
            return RedirectToAction("UyeGörev");
        }


        public ActionResult Login()
        {
            var deger = PTypeDepo.GetAll();

            return View(deger);
        }



    }
}