using DataAccsessLayer.EntityRepositories;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracSatisUygulamasi.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        [HttpGet]
        public ActionResult GetMusteriList()
        {
            MusteriRepository musRep = new MusteriRepository();
            var list = musRep.List();
            return View(list);
        }


        [HttpGet]
        public ActionResult musteriEkle()
        {
            return View();
        }

        [HttpPost]
        public JsonResult musteriEkle(TBL_MUSTERILER m1)
        {
            MusteriRepository musRep = new MusteriRepository();
            var musteriEkle = musRep.musteriEkle(m1);
            return Json(musteriEkle);

        }
    }
}