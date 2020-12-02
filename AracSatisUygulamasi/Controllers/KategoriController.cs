using DataAccsessLayer.EntityRepositories;
using DataEntity;
using System.Web.Mvc;

namespace AracSatisUygulamasi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        [HttpGet]
        public ActionResult kategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public JsonResult kategoriEkle(TBL_KATEGORILER k1)
        {
            KategoriRepository katRep = new KategoriRepository();
            var kategoriEkle = katRep.kategoriEkle(k1);
            return Json(kategoriEkle);

        }





        public ActionResult Index()
        {
            KategoriRepository katRep = new KategoriRepository();
           // var katList = katRep.KategoriAdinaGoreListele();
            return View("");
        }

    }
}