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
    }
}
