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
        [HttpGet]
        public ActionResult GetSatisList()
        {
            SatisRepository satRep = new SatisRepository();
            var list = satRep.List();
            return View(list);
        }

    }
}