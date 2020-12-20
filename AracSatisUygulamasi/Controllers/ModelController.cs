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
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index(string Kategori, string Marka)
        {
            Procedures procedures = new Procedures();
            prc_MODEL_MARKA_ARAC_LIST prms = new prc_MODEL_MARKA_ARAC_LIST
            {
                katAdi = Kategori,
                marAdi = Marka
            };
            var marList = procedures.KATEGORI_MARKA_MODEL_LIST(prms);
            return View(marList);
        }


        public ActionResult ModelDetay(string Kategori, string Marka, string Model)
        {
            Procedures procedures = new Procedures();
            prc_MODEL_DETAY prms = new prc_MODEL_DETAY
            {
                katAdi = Kategori,
                marAdi = Marka,
                modAdi = Model
            };
            var modList = procedures.MODEL_DETAY_SAYFASI(prms);
            return View(modList);
        }


        public JsonResult Sil(int modId)
        {
            ModelRepository modRep = new ModelRepository();
            var modelSil = modRep.IGet(x => x.ID == modId);
            modRep.Delete(modelSil);
            return Json(modRep.Save(), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult modelEkle()
        {
            KategoriRepository repoKategori = new KategoriRepository();
            var a = repoKategori.List().Select(x => new SelectListItem { Text = x.KATEGORI_ADI, Value = x.ID.ToString() }).ToList();
            MarkaRepository repoMarka = new MarkaRepository();
            var b = repoMarka.List().Select(x => new SelectListItem { Text = x.MARKA_ADI, Value = x.ID.ToString() }).ToList();
            ViewBag.kategoriList = a;
            ViewBag.markaList = b;
            return View();
        }


        [HttpPost]
        public JsonResult modelEkle( int kategoriList, int markaList, String MODEL_ADI)
        {
            ModelRepository modRep = new ModelRepository();
            var modelEkle = modRep.modelEkle(new TBL_MODEL
            {
                KATEGORI_ID = kategoriList,
                MARKA_ID=markaList,
                MODEL_ADI = MODEL_ADI
            });
            return Json(modelEkle);
        }

        
       
        public JsonResult Guncelle(int modId)
        {
            ModelRepository modRep = new ModelRepository();
            var modelGuncelle = modRep.IGet(x => x.ID == modId);
            modRep.Update(modelGuncelle);
            modRep.Save();
            return Json(modRep.Save(), JsonRequestBehavior.AllowGet);
        }

    }
}


