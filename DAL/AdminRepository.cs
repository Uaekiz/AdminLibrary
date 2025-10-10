using System.IO;
using System.Text;
using AdminKütüphane.Classes; // Admin sınıfını kullanmak için

namespace AdminKütüphane.DAL // Data Access Layer (Veri Erişim Katmanı) için kısaltma kullanıldı.
{
    internal class AdminRepository
    {
        private const string AdminFilePath = "Datas/AdminBilgileri.txt"; // Dosya yolunu tek bir yerde tanımladık.

        // Görev: Admin bilgilerini dosyadan okur ve Admin nesnesi olarak döndürür.
        public Admin GetAdminCredentials()
        {
            try
            {
                // En güvenilir ve kaynakları yöneten okuma şekli: using bloğu.
                using (StreamReader sra = new StreamReader(AdminFilePath))
                {
                    string AdminInformation = sra.ReadLine() ?? "";

                    if (string.IsNullOrEmpty(AdminInformation))
                    {
                        // Boş bir dosya veya geçersiz format durumunda özel bir hata fırlatılabilir.
                        throw new InvalidDataException("Admin bilgileri dosyada bulunamadı veya boş.");
                    }

                    string[] AInfo = AdminInformation.Split(';');

                    // Verinin doğru sayıda parçaya ayrıldığından emin ol.
                    if (AInfo.Length < 4)
                    {
                        throw new InvalidDataException("Admin bilgileri dosyada eksik veya hatalı formatta.");
                    }

                    // Admin nesnesini oluştur ve doldur
                    return new Admin(AInfo);
                }
            }
            catch (FileNotFoundException)
            {
                // Dosya bulunamazsa kullanıcıya/geliştiriciye uyarı vermek için
                throw new FileNotFoundException($"Hata: Admin bilgileri dosyası ({AdminFilePath}) bulunamadı. Lütfen kontrol edin.");
            }
            catch (Exception ex)
            {
                // Diğer tüm hatalar için genel bir yakalama
                throw new Exception($"Admin bilgilerini okuma sırasında beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }

        public void UpdateAdminFile(string adminData)
        {
            try
            {
                File.WriteAllText(AdminFilePath, adminData, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                // Dosya yazma hatası oluşursa fırlat
                throw new Exception("Admin dosyasına yazma işlemi sırasında bir hata oluştu.", ex);
            }
        }
    }
}