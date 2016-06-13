using HaberPortali.Admin.Models.DTO;
using HaberPortali.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortali.Admin.Controllers
{
    public class AccountController : Controller
    {

        private readonly IKullaniciRepository _kullaniciRepository;

        public AccountController(IKullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(KullaniciVM model)
        {
            var kullaniciVarmi = _kullaniciRepository.GetMany(x => x.Email == model.Email && x.Sifre == model.Sifre).SingleOrDefault();

            if(kullaniciVarmi!=null)
            {
                if(kullaniciVarmi.Rol.RolAdi=="Admin")
                {
                    Session["KullaniciEmail"] = kullaniciVarmi.Email;
                    Session["Kullanici"] = kullaniciVarmi.AdSoyad;
                    return RedirectToAction("Index","Home");
                }
                ViewBag.Mesaj = "Kullanıc yetkiniz admin olmalı";
                return View();
            }
            ViewBag.Mesaj = "Kullanıcı bulunamadı";
            return View();
        }

    }
}