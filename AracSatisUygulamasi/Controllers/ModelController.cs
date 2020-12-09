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
    }
}


