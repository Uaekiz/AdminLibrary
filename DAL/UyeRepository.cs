using AdminKütüphane.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdminKütüphane.DAL
{
    // Bu sınıfın tek sorumluluğu Üye verilerini dosyadan okumak/yazmaktır. (Data Access Layer)
    public class UyeRepository
    {
        private const string UyeFilePath = "Datas/Üyeler.txt";

        /// <summary>
        /// Üyeler.txt dosyasındaki tüm üyeleri okur ve bir liste olarak döndürür.
        /// </summary>
        public List<Uye> GetAllUyeler()
        {
            var uyeler = new List<Uye>();

            if (!File.Exists(UyeFilePath))
            {
                // Dosya bulunamazsa boş liste döndürerek programın çökmesini engelleriz.
                // Hata yönetimi daha sonra Manager katmanında yapılabilir.
                return uyeler;
            }

            var satirlar = File.ReadAllLines(UyeFilePath, Encoding.UTF8);

            foreach (var satir in satirlar)
            {
                if (string.IsNullOrWhiteSpace(satir)) continue; // Boş satırları atla

                var parcalar = satir.Split(';');
                if (parcalar.Length < 3) continue; // Hatalı formatta satırları atla

                var uye = new Uye
                {
                    UyeAdi = parcalar[0],
                    UyeId = int.TryParse(parcalar[1], out int id) ? id : 0,
                    AlinanKitapSayisi = int.TryParse(parcalar[2], out int sayi) ? sayi : 0
                };

                // Eğer 4. parça (alınan kitaplar) varsa ve boş değilse listeye ekle
                if (parcalar.Length > 3 && !string.IsNullOrEmpty(parcalar[3]))
                {
                    uye.AlinanKitaplar = new List<string>(parcalar[3].Split(','));
                }

                uyeler.Add(uye);
            }

            return uyeler;
        }
    }
}