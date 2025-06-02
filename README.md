# 🎓 Gazi Edukate – ASP.NET Core Tabanlı Yabancı Dil Eğitim Platformu

**Gazi Edukate**, öğretmenlerin PDF tabanlı ödev hazırlayıp öğrencilere sunabildiği, ayrıca boşluk doldurma gibi dil eğitimi çalışmaları oluşturabildiği, kullanıcı dostu bir öğretmen paneli sunan modern bir web uygulamasıdır. 

Bu proje, **Gazi Üniversitesi** kapsamında, **ASP.NET Core MVC** teknolojileriyle geliştirilmiştir ve "Liveworksheets" gibi eğitim platformlarına ilham alarak geliştirilmiş özgün bir sistemdir. Öğretmenler, sistem üzerinden öğrenciler için PDF ödevler yükleyebilir, yeni çalışmalar oluşturabilir ve bu çalışmaları hem veritabanında saklayabilir hem de PDF formatında dışa aktarabilir.

---

## 🚀 Proje Özeti

Gazi Edukate, yabancı dil eğitimine katkı sunmak amacıyla geliştirilen bir içerik yönetim sistemidir. Projede öğretmenler, sisteme giriş yaptıktan sonra öğrencilere yönelik PDF ödevleri ve çalışmaları hazırlayabilmekte; bu içerikleri hem dijital ortamda saklamakta hem de çıktı olarak indirebilmektedir.

Sistem; kullanıcı rolleri (öğrenci, öğretmen), oturum yönetimi, dosya yükleme, PDF üretimi, SQL veritabanı bağlantısı ve içerik oluşturma bileşenlerini içermektedir.

---

## ⚙️ Kullanılan Teknolojiler

- **ASP.NET Core MVC** – Web uygulama çatısı
- **Entity Framework Core** – ORM ve SQL Server bağlantısı
- **Rotativa.AspNetCore** – PDF üretimi
- **Bootstrap 5** – Modern responsive arayüz
- **Razor View Engine** – View sayfa oluşturma
- **MSSQL Server** – Veritabanı
- **Session Management** – Oturum takibi ve yetkilendirme

---

## 👨‍🏫 Öğretmen Paneli Özellikleri

- 🔐 Giriş sistemi (E-posta/TC ve şifre)
- 📄 Ödev yükleme (PDF dosya + başlık + açıklama)
- 📁 Ödevleri listeleme ve görüntüleme
- 🧠 Boşluk doldurma çalışması oluşturma
- 🖨️ PDF formatında çıktı alma
- 🗃️ Oluşturulan çalışmaları veritabanında saklama
- 👥 Öğrenci listesi görüntüleme
- 🚪 Güvenli çıkış yapma (Session temizleme)

---

## 🧩 Proje Dosya Yapısı

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

🧪 Test Senaryosu
Sisteme öğretmen olarak giriş yapılır.

Ödev yükleme sayfasına gidilerek PDF eklenir.

Yüklenen ödevler listelenir ve bağlantı üzerinden görüntülenir.

Boşluk doldurmalı bir içerik oluşturulur.

Bu içerik PDF olarak indirilir veya veritabanına kaydedilir.

Öğrenci listesi görüntülenerek kontrol yapılır.

📌 Geliştirme Aşamaları
 Giriş ve yetkilendirme sistemi

 PDF ödev yükleme

 Ödev listeleme/görüntüleme

 Boşluk doldurma çalışması oluşturma ve PDF çıktısı alma

 Öğrenci listesi oluşturma

 Öğrencilerin PDF çözüm yüklemesi (planlandı)

 Öğretmen onay ve puanlama modülü (planlandı)

📎 Proje Hedefi ve Katma Değeri
Bu uygulama, öğretmenlerin dijital içerik üretimini kolaylaştırmayı, öğrencilere bireysel ve hedefe yönelik dil eğitimi materyali sunmayı ve tüm bu süreci dijital ortamda saklamayı hedeflemektedir. Aynı zamanda PDF çıktısıyla klasik eğitim alışkanlıklarını da desteklemektedir.

💬 Geliştiren
👨‍💻 Geliştirici: İsmail Dündar
🎓 Üniversite: Gazi Üniversitesi
📚 Ders: Bilgisayar Proje Tasarımı Dersi
🗓️ Dönem: 2025 Bahar
📝 Lisans

🖼️ Ekran Görselleri
![1](https://github.com/user-attachments/assets/03446d19-e5cb-4a1a-adab-7c433e9b7c51)
![2](https://github.com/user-attachments/assets/e3c42740-6577-45fb-9fa1-e1bab9464902)
![3](https://github.com/user-attachments/assets/0ed5a25e-0b3b-4c1e-a9a7-78312863ecd6)
![5](https://github.com/user-attachments/assets/3ef0c396-5e28-4d1c-9d48-81d7a815a87a)
![6](https://github.com/user-attachments/assets/ee151e06-348f-40da-8c0c-b9cfbda6394d)
![7](https://github.com/user-attachments/assets/ebfefa7e-fcf1-4fa0-b342-96705d215613)
![8](https://github.com/user-attachments/assets/bb56de30-8306-412d-b0b8-d3129c6bb44e)
![9](https://github.com/user-attachments/assets/1b55af19-b469-4d5b-a574-c6193002a987)


Bu proje eğitim amaçlıdır. Gönüllü katkılara açıktır. Geri bildirimlerinizi ve önerilerinizi memnuniyetle karşılarız.


