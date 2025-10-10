using AdminKütüphane.DAL;
using System.Collections.Generic;

namespace AdminKütüphane.Classes
{
    // Bu sınıf Üye ile ilgili iş mantığını yönetir. (Business Logic Layer)
    public class UyeManager
    {
        private UyeRepository _uyeRepository;

        public UyeManager()
        {
            _uyeRepository = new UyeRepository();
        }

        /// <summary>
        /// Tüm üyelerin listesini getiren metot.
        /// </summary>
        /// <returns>Uye nesnelerinden oluşan bir liste.</returns>
        public List<Uye> GetTumUyeler()
        {
            // İş mantığı şimdilik sadece veri katmanını çağırmak.
            // İleride buraya filtreleme, sıralama gibi kurallar eklenebilir.
            return _uyeRepository.GetAllUyeler();
        }
    }
}