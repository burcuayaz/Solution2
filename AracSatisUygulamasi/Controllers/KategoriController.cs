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

        /*  [HttpPost]
          public ActionResult kategoriEkle(TBL_KATEGORILER p1)
          {
              KategoriRepository katRep = new KategoriRepository();
              var katEkle = katRep.Insert(p1);
              return View();
          }
        */
        [HttpPost]
        public ActionResult kategoriEkle(TBL_KATEGORILER p1)
        {

            if (!ModelState.IsValid)                                   //bize bunu gezerli olup olmadığını söyledi
            {
                return View(p1);
            }
            else
            {
                KategoriRepository adRep = new KategoriRepository();
                var adminEkle = adRep.kategoriEkle(p1);
                return RedirectToAction(nameof(kategoriEkle));
            }


        }


        public ActionResult Index()
        {
            KategoriRepository katRep = new KategoriRepository();
           // var katList = katRep.KategoriAdinaGoreListele();
            return View("");
        }

    }
}