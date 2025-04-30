# EasyCash Banka Web Projesi
## Projenin Genel Amacı

###
EasyCash; banka web siteleri mantığında işleyen gerçek dünya senaryolarına uygun hazırlanmış bir web projesidir. Bu sitede Admin, Müşteri ve Ana Sayfa için ayrı paneller hazırlanmış olup Identity ile oturum işlemleri gerçekleştirilmiştir. 
Kayıt Ol sayfası aracılığıyla kayıt olan kullanıcı Müşteri Paneli'ne yönlendirilmektedir. Kullanıcı bu panelde tüm hesaplarını (Dolar, Euro, TL) görebilir, kredi/banka kartı başvurusunda bulunabilir, sistemde kayıtlı
olan bir IBAN'a para transferi gerçekleştirebilir, elektrik faturası ödeme işlemi gerçekleştirebilir vb.

ASP.NET Core 6.0 MVC kullanarak geliştirdiğim projemde dinamik veritabanı işlemleri için Entity Framework Code First kullanılmıştır.
###

# Kullanılan Teknolojiler
- Asp.Net Core 6.0 MVC
- Katmanlı Mimari
- MSSQL Server
- Entity Framework Code First
- Identity
- Html, Css
- JavaScript
- AJAX
- Bootstrap
- Sweet Alert
- QRCode Generator
- Döviz Kurları Apisi
- AutoMapper
  
# Projenin Öne Çıkan Özellikleri
- Müşteri paneli ekranında(Dashboard) güncel döviz kuru bilgilerini grafikte görüntüleyebilme
- Veritabanı işlemleri için Entity Framework Code First kullanımı
- Müşteri Paneli
- Identity ile Giriş ve Kayıt Olma işlemleri
- Profil ayarları sayfası
- Giriş yapan kişinin hesaplarını görüntüleyebilmesi
- Giriş yapan kişinin kendi hesabının IBAN'ını kopyalayabilmesi işlemi
- Kredi/Banka kartı başvurusunda bulunabilme
- Sistemde kayıtlı IBAN'a para transferi yapabilme
- Elektrik Faturası ödeyebilme işlemleri
- QR Kodu oluşturabilme ekranı
- Kayıt olunan email'e kod gönderme yaparak Email onaylama işlemi gerçekleştirme
