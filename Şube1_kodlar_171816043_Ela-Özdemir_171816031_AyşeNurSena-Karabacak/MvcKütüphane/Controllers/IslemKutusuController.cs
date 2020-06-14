using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcKütüphane.Models.Entity;

namespace MvcKütüphane.Controllers
{
    public class IslemKutusuController : Controller
    {
        // GET: IslemKutusu
        DBKÜTÜPHANEEntities db = new DBKÜTÜPHANEEntities();
        public ActionResult Index()
        {
            var duyurulistesi = db.TBLILETISIM.ToList();
            return View(duyurulistesi);
        }
    }
}