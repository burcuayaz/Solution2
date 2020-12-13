using DataAccsessLayer.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracSatisUygulamasi.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        public JsonResult GetSatisListJson()
        {
            SatisRepository satRep = new SatisRepository();
            return Json(new { data = satRep.List() }, JsonRequestBehavior.AllowGet);
        }

      

        public ActionResult GetSatisListView()
        {
            return View();
        }
    }
}