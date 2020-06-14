using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKütüphane.Models.Entity;
using System.Web.Security;

namespace MvcKütüphane.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        DBKÜTÜPHANEEntities db = new DBKÜTÜPHANEEntities();
        public ActionResult AdminGirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminGirisYap(TBLPERSONEL P)
        {
            var bilgiler = db.TBLPERSONEL.FirstOrDefault(x => x.PERSONEL == P.PERSONEL && x.SIFRE == P.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.PERSONEL, false);
                return RedirectToAction("Index", "istatistik");
            }
            else
            {
                return View();
            }

        }

    }
}