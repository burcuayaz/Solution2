
using DataAccsessLayer.Abstract;
using DataAccsessLayer.DTOs;
using DataAccsessLayer.EntityRepositories;
using DataEntity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AracSatisUygulamasi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }





        [HttpGet]
        public ActionResult kullaniciEkle()
        {
            return View();
        }

        [HttpPost]
        public JsonResult kullaniciEkle(TBL_KULLANICI k1)
        {
            AdminRepository adRep = new AdminRepository();
            var adminEkle = adRep.kullaniciEkle(k1);
            return Json(adminEkle);

        }





        [HttpGet]
        public ActionResult GetKullaniciList()
        {
            AdminRepository adRep = new AdminRepository();
            var list = adRep.List();
            return View(list);
        }


        public ActionResult SideMenu()
        {
            Repository<TBL_KATEGORILER> repoKategori = new Repository<TBL_KATEGORILER>();
            var TBL_KATEGORILER = repoKategori.List();
            return PartialView("SideMenu", TBL_KATEGORILER);
        }
    }
}