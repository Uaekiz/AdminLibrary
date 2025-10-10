using AdminKütüphane.DAL;
using System.IO;

namespace AdminKütüphane.Classes
{
    public class AdminManager
    {
        // AdminManager, DAL katmanını (Repository'yi) kullanır.
        private AdminRepository _repository;
        private Admin _admin;

        public AdminManager()
        {
            _repository = new AdminRepository();
            try
            {
                _admin = _repository.GetAdminCredentials();
            }
            catch (Exception)
            {
                // Hata oluşursa, _admin nesnesi null kalacak.
                // Bu durumu Authenticate metodunda kontrol edeceğiz.
                _admin = null;
            }
        }

        // ----------------------------------------------------
        // Iş Mantığı Metotları (Eski Admin.cs'den taşındı)
        // ----------------------------------------------------

        /// <summary>
        /// ID ve şifre kontrolünü yaparak Admin nesnesini döndürür.
        /// </summary>
        public (string, string) Authenticate(string idGirdi, string sifreGirdi)
        {
            if (_admin == null)
            {
                return ("CRITICAL_ERROR", "Sistem yöneticisi bilgileri yüklenemedi.");
            }

            if (string.IsNullOrEmpty(idGirdi))
            {
                return ("ID_EMPTY", "Lütfen ID alanını boş bırakmayınız!");
            }

            if (string.IsNullOrEmpty(sifreGirdi))
            {
                return ("PASSWORD_EMPTY", "Lütfen şifre alanını boş bırakmayınız!");
            }

            if (!int.TryParse(idGirdi, out int parsedId))
            {
                return ("INVALID_ID_FORMAT", "Hatalı giriş yaptınız! Lütfen tekrar deneyiniz.");
            }

            if (_admin.IdKontrol(parsedId) && _admin.SifreKontrol(sifreGirdi))
            {
                return ("SUCCESS", "Giriş başarılı!");
            }
            else
            {
                return ("INVALID_CREDENTIALS", "Hatalı ID veya şifre! Lütfen tekrar deneyiniz.");
            }
        }

        // ----------------------------------------------------
        // Şifre Değiştirme Mantığı (Eski Admin.cs'den taşındı ve Forms uyumlu hale getirildi)
        // ----------------------------------------------------

        // NOT: SifreDegis metodu karmaşık ve Console.Write kullanıyor.
        // Bu metodu Windows Forms'a uygun hale getirmek için
        // BLL'de bu yapının daha sade bir versiyonunu tutuyoruz.
        // Asıl C# Forms (Login.cs) bunu farklı bir metotla halletmelidir.

        // Şimdilik sadece dosyaya yazma işlemini DAL'e ekleyelim:

        public bool UpdateAdminSifre(string yeniSifre, int adminId, string guvenlikSorusu, string guvenlikCevap)
        {
            // Bu metot, sadece bir Admin nesnesi oluşturur ve DAL'i kullanarak dosyaya yazar.
            // Bu, eski SifreDegis metodunun yapması gereken tek işti.

            string yeniBilgi = $"{yeniSifre};{adminId};{guvenlikSorusu};{guvenlikCevap}";

            // Veri yazma işini DAL'e devrediyoruz.
            _repository.UpdateAdminFile(yeniBilgi);

            return true;
        }
    }
}