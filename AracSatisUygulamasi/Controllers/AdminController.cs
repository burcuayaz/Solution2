using DataAccsessLayer.Abstract;
using DataAccsessLayer.EntityRepositories;
using DataEntity;
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
        public ActionResult kullaniciEkle(TBL_KULLANICI k1)
        {
           
            if (!ModelState.IsValid)                                   //bize bunu gezerli olup olmadığını söyledi
            {
                return View(k1);
            }
            else
            {
                AdminRepository adRep = new AdminRepository();
                var adminEkle = adRep.kullaniciEkle(k1);
                return RedirectToAction(nameof(kullaniciEkle));
            }
           // return Json(k1, JsonRequestBehavior.AllowGet);


        }


        public ActionResult SideMenu()
        {
            Repository<TBL_KATEGORILER> repoKategori = new Repository<TBL_KATEGORILER>();
            var TBL_KATEGORILER = repoKategori.List();
            return PartialView("SideMenu", TBL_KATEGORILER);
        }
    }
}