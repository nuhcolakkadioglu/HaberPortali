using HaberPortali.Admin.Class;
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
          
            return View(_kategoriRepository.GetAll().ToList());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            SetKategoriListele();
            return View();
        }

        [HttpPost]
        public JsonResult Ekle(Kategori model)
        {
            try
            {
                _kategoriRepository.Insert(model);
                _kategoriRepository.Save();
                return Json(new ResultJson {Success=true, Message="Kategori ekleme işleminiz ok"});
            }
            catch (Exception)
            {
                return Json(new ResultJson { Success = false, Message = "kategori eklenemedi" });
               
            }

        }

        public void SetKategoriListele()
        {
            var KategoriList = _kategoriRepository.GetMany(m=>m.ParentID==0).ToList();
            ViewBag.Kategori = KategoriList;
        }

      public JsonResult Sil(int id)
        {
            Kategori kategori = _kategoriRepository.GetById(id);
            if (kategori == null)
                return Json(new ResultJson { Success = false, Message = "kategori bulunamadı" });

            _kategoriRepository.Delete(id);
            _kategoriRepository.Save();

            return Json(new ResultJson { Success=true,Message="kategori silindi"});

        }

    }
}