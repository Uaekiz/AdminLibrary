using System.Collections.Generic;

namespace AdminKütüphane.Classes
{
    // Bu sınıf SADECE bir üyenin verilerini tutar. Başka hiçbir iş yapmaz. (Model veya POCO)
    public class Uye
    {
        public string UyeAdi { get; set; }
        public int UyeId { get; set; }
        public int AlinanKitapSayisi { get; set; }
        public List<string> AlinanKitaplar { get; set; }

        // Yapıcı metot (Constructor), nesne oluşturulurken verilerin atanmasını kolaylaştırır.
        public Uye()
        {
            // Kitap listesinin null (boş) kalmasını engellemek için başlatıyoruz.
            AlinanKitaplar = new List<string>();
        }
    }
}