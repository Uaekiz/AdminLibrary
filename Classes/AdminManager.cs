using AdminKütüphane.DAL;
using System.IO;

namespace AdminKütüphane.Classes
{
    public class AdminManager
    {
        // AdminManager, DAL katmanını (Repository'yi) kullanır.
        private AdminRepository _repository;

        public AdminManager()
        {
            _repository = new AdminRepository();
        }

        // ----------------------------------------------------
        // Iş Mantığı Metotları (Eski Admin.cs'den taşındı)
        // ----------------------------------------------------

        /// <summary>
        /// ID ve şifre kontrolünü yaparak Admin nesnesini döndürür.
        /// </summary>
        //public Admin Authenticate(string idGirdi, string sifreGirdi, out string? errorMessage)
        //{
        //    errorMessage = null;

        //    // 1. Veri Alımı (DAL kullanılır)
        //    Admin admin;
        //    try
        //    {
        //        admin = _repository.GetAdminCredentials();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Veri okuma hatasını direkt döndür
        //        errorMessage = "Sistem verileri yüklenirken kritik bir hata oluştu: " + ex.Message;
        //        return null;
        //    }

        //    // 2. ID ve Şifre Kontrolü (Eski Admin metotlarının mantığı burada birleşti)
        //    if (!int.TryParse(idGirdi, out int parsedId))
        //    {
        //        errorMessage = "ID sayısal bir değer olmalıdır!";
        //        return null;
        //    }

        //    // Kontrol: Hem ID hem de Şifre doğru mu?
        //    if (parsedId == admin.AdminId && sifreGirdi == admin.Sifre)
        //    {
        //        return admin; // Başarılı
        //    }
        //    else
        //    {
        //        errorMessage = "Hatalı ID veya Şifre!";
        //        return null; // Başarısız
        //    }
        //}

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