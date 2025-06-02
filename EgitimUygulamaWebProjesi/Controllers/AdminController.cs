using EgitimUygulamaWebProjesi.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgitimUygulamaWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        EgitimSitesiProjeTasarimiEntities1 db = new EgitimSitesiProjeTasarimiEntities1();

        // GET: Çalışma Oluştur Sayfası
        public ActionResult YeniCalisma()
        {
            return View();
        }

        // POST: PDF Olarak İndir
        [HttpPost]
        public ActionResult YeniCalisma(string baslik, string icerik, string islem)
        {
            int ogretmenId = Convert.ToInt32(Session["KullaniciId"]);

            if (islem == "kaydet")
            {
                // PDF olarak kaydet ve klasöre yükle
                string klasor = Server.MapPath("~/Dosyalar");
                if (!Directory.Exists(klasor))
                    Directory.CreateDirectory(klasor);

                string dosyaAdi = Guid.NewGuid().ToString() + ".pdf";
                string tamYol = Path.Combine(klasor, dosyaAdi);
                string pdfYolu = "/Dosyalar/" + dosyaAdi;

                // PDF üretimi
                using (FileStream fs = new FileStream(tamYol, FileMode.Create))
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    doc.Add(new Paragraph(baslik) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph(icerik));
                    doc.Close();
                }

                // Veritabanına ekle
                var calisma = new PdfCalismalar
                {
                    Baslik = baslik,
                    Icerik = icerik,
                    PdfYolu = pdfYolu,
                    YuklenmeTarihi = DateTime.Now,
                    OgretmenId = ogretmenId
                };

                db.PdfCalismalar.Add(calisma);
                db.SaveChanges();

                ViewBag.Mesaj = "Çalışma başarıyla veritabanına kaydedildi.";
                return View();
            }
            else if (islem == "indir")
            {
                // Geçici olarak hafızada PDF oluştur ve indir
                using (MemoryStream ms = new MemoryStream())
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, ms).CloseStream = false;
                    doc.Open();
                    doc.Add(new Paragraph(baslik) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph(icerik));
                    doc.Close();

                    byte[] pdfBytes = ms.ToArray();
                    return File(pdfBytes, "application/pdf", "Calisma_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");
                }
            }

            return View();
        }






        public ActionResult Odevler()
        {
            int ogretmenId = Convert.ToInt32(Session["KullaniciId"]);
            var odevler = db.Odevler
                            .Where(x => x.OgretmenId == ogretmenId)
                            .OrderByDescending(x => x.YuklenmeTarihi)
                            .ToList();
            return View(odevler);
        }

        // Silme işlemi
        public ActionResult OdevSil(int id)
        {
            var odev = db.Odevler.Find(id);
            if (odev != null)
            {
                string fizikselYol = Server.MapPath(odev.DosyaYolu);
                if (System.IO.File.Exists(fizikselYol))
                {
                    System.IO.File.Delete(fizikselYol);
                }

                db.Odevler.Remove(odev);
                db.SaveChanges();
            }
            return RedirectToAction("Odevler");
        }



        public ActionResult OgrenciListesi()
        {
            var ogrenciler = db.Kullanicilar
                               .Where(x => x.Rol == "Ogrenci")
                               .OrderBy(x => x.AdSoyad)
                               .ToList();

            return View(ogrenciler);
        }


        // Admin ana sayfası (yüklenen ödevler listeleniyor)
        public ActionResult Index()
        {
            int ogretmenId = Convert.ToInt32(Session["KullaniciId"]);

            var odevler = db.Odevler
                .Where(x => x.OgretmenId == ogretmenId)
                .OrderByDescending(x => x.YuklenmeTarihi)
                .ToList();

            return View(odevler);
        }

        // GET: OdevEkle
        public ActionResult OdevEkle()
        {
            return View();
        }

        // POST: OdevEkle
        [HttpPost]
        public ActionResult OdevEkle(HttpPostedFileBase dosya, string Baslik, string Aciklama)
        {
            if (dosya != null && dosya.ContentLength > 0)
            {
                // 1️⃣ Dosya klasörünü oluştur (varsa geç)
                string klasorYolu = Server.MapPath("~/Dosyalar");
                if (!Directory.Exists(klasorYolu))
                    Directory.CreateDirectory(klasorYolu);

                // 2️⃣ Dosya adını ve tam yolu oluştur
                string dosyaAdi = Path.GetFileName(dosya.FileName);
                string tamYol = Path.Combine(klasorYolu, dosyaAdi);

                // 3️⃣ Dosyayı fiziksel olarak kaydet
                dosya.SaveAs(tamYol);

                // 4️⃣ Veritabanına kayıt
                var odev = new Odevler
                {
                    Baslik = Baslik,
                    Aciklama = Aciklama,
                    DosyaYolu = "/Dosyalar/" + dosyaAdi, // Web yolu
                    YuklenmeTarihi = DateTime.Now,
                    OgretmenId = Convert.ToInt32(Session["KullaniciId"])
                };

                db.Odevler.Add(odev);
                db.SaveChanges();

                ViewBag.Mesaj = "✅ PDF başarıyla yüklendi.";
            }
            else
            {
                ViewBag.Mesaj = "⚠️ Lütfen bir dosya seçiniz.";
            }

            return View();
        }
    }
}
