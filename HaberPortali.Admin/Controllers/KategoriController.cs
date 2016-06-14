using HaberPortali.Core.Infrastructure;
using HaberPortali.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortali.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        private readonly IKategoriRepository _kategoriRepository;

        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Ekle(Kategori model)
        {
            return Json(1,JsonRequestBehavior.AllowGet);
        }
    }
}