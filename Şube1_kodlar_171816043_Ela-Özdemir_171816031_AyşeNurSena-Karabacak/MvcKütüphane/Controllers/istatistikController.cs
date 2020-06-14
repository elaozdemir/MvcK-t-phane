using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcKütüphane.Models.Entity;
namespace MvcKütüphane.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik
        DBKÜTÜPHANEEntities db = new DBKÜTÜPHANEEntities();
       [Authorize]
        public ActionResult Index()
        {
            var deger1 = db.TBLUYELER.Count();//sayıları iststistik sayfasında kartlarda görüntülemek için
            var deger2 = db.TBLKITAP.Count();
            var deger3 = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            var deger4 = db.TBLCEZALAR.Sum(x => x.PARA);
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2= deger2;
            ViewBag.dgr3 = deger3;
            ViewBag.dgr4 = deger4;
            return View();
        }
        public ActionResult Hava()
        {
             return View();

        }
        public ActionResult Galeri()
        {
            return View();

        }
        [HttpPost]
        public ActionResult resimyukle(HttpPostedFileBase dosya)
        {
            if(dosya.ContentLength>0)
            {
                string dosyayolu=Path.Combine(Server.MapPath("~/web2/resimler/"), Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyayolu);
            }
            return RedirectToAction("Galeri");
        }
        public ActionResult LinqKart()
        {
            return View();
        }

    }
}