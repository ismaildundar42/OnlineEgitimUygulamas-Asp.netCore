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

📸 Ekran Görüntüleri
Aşağıda projeye ait tüm sayfaların ekran görüntülerini sıralı olarak ekleyiniz:
![1](https://github.com/user-attachments/assets/2569f23d-8f54-4cb5-8b04-ddf192a412c9)
![2](https://github.com/user-attachments/assets/506cfdda-c27a-46d1-be57-499c44eba6d1)
![3](https://github.com/user-attachments/assets/ad066a53-8c4e-4cfe-9bab-ea5f0b372b28)
![4](https://github.com/user-attachments/assets/d42eaad5-b6ad-4f69-9356-211988e74f67)
![5](https://github.com/user-attachments/assets/cffaaa8b-eeab-4085-a34b-c83558ba86d3)
![6](https://github.com/user-attachments/assets/b7813860-9a66-4cae-97ab-4e02ac781b7d)
![7](https://github.com/user-attachments/assets/c95d8220-3905-4c23-a6cd-e021571e9ae4)
![8](https://github.com/user-attachments/assets/051b83f8-7c9d-4c6c-b2e2-1493053a9101)
![9](https://github.com/user-attachments/assets/58bb43f7-0d63-4592-9ab3-0beb13b32e4c)


