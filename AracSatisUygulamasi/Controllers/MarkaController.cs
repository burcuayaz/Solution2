using DataAccsessLayer.Abstract;
using DataAccsessLayer.EntityRepositories;
using DataAccsessLayer.Procedures;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataAccsessLayer.ProdecureModels.ProdecureModels;

namespace AracSatisUygulamasi.Controllers
{
    public class MarkaController : Controller
    {
        // GET: Marka
        public ActionResult Index(string Kategori) //  Marka?Kategori=Otomobil&Marka=Audi
        {
            Procedures procedures = new Procedures();
            prc_MODEL_ARAC_LIST prms = new prc_MODEL_ARAC_LIST
            {
                katAdi = Kategori
            };
            var marList = procedures.KATEGORI_ARAC_LIST(prms);
            return View(marList);
        }


        [HttpGet]
        public ActionResult markaEkle()
        {
            KategoriRepository repoKategori = new KategoriRepository();
            var a= repoKategori.List().Select(x =>new SelectListItem { Text = x.KATEGORI_ADI, Value =x.ID.ToString() }).ToList();
            ViewBag.kategoriList = a;
            return View();
        }


        [HttpPost]
        public JsonResult markaEkle(int kategoriList,string MARKA_ADI)
        {
            MarkaRepository marRep = new MarkaRepository();
            var markaEkle = marRep.markaEkle(new TBL_MARKA { 
                KATEGORI_ID=kategoriList,
                MARKA_ADI=MARKA_ADI
            });
            return Json(markaEkle);

        }
    }
}
