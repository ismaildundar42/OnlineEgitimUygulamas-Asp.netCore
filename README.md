# 🎓 Gazi Edukate – ASP.NET Core MVC Tabanlı Yabancı Dil Eğitim Platformu

**Gazi Edukate**, Gazi Üniversitesi Bilgisayar Proje Tasarımı dersi kapsamında geliştirilen, öğretmenlerin PDF ödevleri hazırlayıp öğrencilere sunabildiği, boşluk doldurma gibi dil eğitimi çalışmaları oluşturabildiği modern bir web uygulamasıdır. Bu sistem, dijital içerik üretimini kolaylaştırmayı ve hem dijital hem yazılı eğitim materyallerini bir arada sunmayı hedefler.

---

## 🚀 Proje Amacı

Bu platform; öğretmenlerin bireysel ve hedefe yönelik eğitim içerikleri üretmesini, bu içerikleri sistemde arşivlemesini ve öğrencilerle etkileşimli biçimde paylaşmasını amaçlamaktadır. Aynı zamanda PDF çıktılar sayesinde geleneksel yöntemlerle eğitime devam imkânı da sunar.

---

## ⚙️ Kullanılan Teknolojiler

- **ASP.NET Core MVC** – Uygulama çatısı
- **Entity Framework Core** – ORM ve SQL Server ile veri işlemleri
- **Rotativa.AspNetCore** – PDF çıktısı alma
- **Bootstrap 5** – Responsive tasarım
- **Razor View Engine** – View sayfaları
- **MSSQL Server** – Veritabanı altyapısı
- **Session Management** – Yetkilendirme ve oturum kontrolü

---

## 👨‍🏫 Öğretmen Paneli Özellikleri

- 🔐 Güvenli giriş sistemi (TC/Eposta + Şifre)
- 📄 PDF ödev yükleme (Açıklama + dosya)
- 🗂️ Ödev listeleme ve görüntüleme
- 🧠 Boşluk doldurma çalışması oluşturma
- 🖨️ PDF çıktısı alma
- 👥 Öğrenci listesi görüntüleme
- 🚪 Güvenli çıkış (Session temizleme)

---

## 🗂️ Proje Dosya Yapısı

```plaintext
/Controllers
|-- AdminController.cs
|-- LoginController.cs

/Models
|-- Kullanici.cs
|-- Odevler.cs
|-- Calismalar.cs

/Views
|-- /Admin
|     |-- Index.cshtml
|     |-- OdevEkle.cshtml
|     |-- YeniCalisma.cshtml
|     |-- OgrenciListesi.cshtml
|-- /Shared
|     |-- _OgretmenLayout.cshtml
|-- /Login
|     |-- Index.cshtml

/wwwroot
|-- /Dosyalar (Yüklenen PDF ödevler)
|-- /css, /js, /resimler

🔍 Test Senaryosu
Öğretmen girişi yapılır.

Ödev ekleme ekranına gidilip PDF dosyası yüklenir.

Yüklenen ödevler listelenir ve kontrol edilir.

Yeni bir boşluk doldurma çalışması hazırlanır.

PDF çıktısı alınır ve veritabanına kaydedilir.

Öğrenci listesi görüntülenerek sistem doğrulanır.

🛠️ Geliştirme Aşamaları
✅ Giriş ve yetkilendirme

✅ PDF ödev yükleme ve listeleme

✅ Boşluk doldurma çalışması ve çıktısı

✅ Öğrenci listeleme

🔄 Öğrenci çözüm yükleme (Planlandı)

🔄 Puanlama ve onay sistemi (Planlandı)

🎯 Katma Değer
Öğretmenlere dijital içerik üretim kolaylığı

Öğrencilere bireyselleştirilmiş içerik desteği

Klasik ve dijital eğitimi bir araya getiren yapı

Arşivleme ve çıktı alma imkanı

👨‍💻 Geliştirici Bilgileri
Geliştirici: İsmail Dündar

Üniversite: Gazi Üniversitesi

Ders: Bilgisayar Proje Tasarımı

Dönem: 2025 Bahar

Proje Türü: Lisans / Eğitim Amaçlı

🤝 Katkı ve İletişim
Proje eğitim amacıyla geliştirilmiştir. Gönüllü katkılara açıktır. Geri bildirim ve katkılarınız için GitHub üzerinden iletişime geçebilirsiniz.
