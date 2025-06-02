using System.Linq;
using System.Web.Mvc;
using EgitimUygulamaWebProjesi.Models;

namespace EgitimUygulamaWebProjesi.Controllers
{
    public class LoginController : Controller
    {
        EgitimSitesiProjeTasarimiEntities1 db = new EgitimSitesiProjeTasarimiEntities1();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Index(string eposta, string sifre)
        {
            var kullanici = db.Kullanicilar
                .FirstOrDefault(x => x.Eposta == eposta && x.Sifre == sifre);

            if (kullanici != null)
            {
                // ✅ Oturum bilgilerini atıyoruz
                Session["KullaniciId"] = kullanici.KullaniciId;
                Session["AdSoyad"] = kullanici.AdSoyad;
                Session["Rol"] = kullanici.Rol;

                if (kullanici.Rol == "Ogretmen")
                    return RedirectToAction("Index", "Admin");

                if (kullanici.Rol == "Ogrenci")
                    return RedirectToAction("Index", "Default");

                ViewBag.Hata = "Tanımlı bir rol bulunamadı.";
                return View();
            }

            ViewBag.Hata = "E-posta veya şifre hatalı.";
            return View();
        }

    }
}
