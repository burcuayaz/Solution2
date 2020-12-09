
using DataAccsessLayer.Abstract;
using DataAccsessLayer.DTOs;
using DataAccsessLayer.EntityRepositories;
using DataEntity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace AracSatisUygulamasi.Controllers
{

    public class AdminController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
      

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(KullaniciDTOs kullanici)
        {
            KullaniciDTOs kulDTO = new KullaniciDTOs();
            var result = new AdminRepository().List().FirstOrDefault(x => x.KULLANICI_ADI.Contains(kullanici.KullaniciAdi) && x.SIFRE.Contains(kullanici.Sifre));
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(result.KULLANICI_ADI, false);
                return RedirectToAction("Index","Admin");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
        }


        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            return RedirectToAction("Index");
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
            return View("GetKullaniciList", list);
        }


        public ActionResult SideMenu()
        {
            Repository<TBL_KATEGORILER> repoKategori = new Repository<TBL_KATEGORILER>();
            var TBL_KATEGORILER = repoKategori.List();
            return PartialView("SideMenu", TBL_KATEGORILER);
        }
    }
}