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

        public List<Uye> FindUye(string input)
        {
            var bulunanUyeler = new List<Uye>();
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            var tumUyeler = _uyeRepository.GetAllUyeler();
            foreach (var uye in tumUyeler)
            {
                if (uye.UyeAdi.ToLower().Contains(input.ToLower()) || uye.UyeId.ToString() == input)
                {
                    bulunanUyeler.Add(uye);
                }
            }
            return bulunanUyeler;
        }

        public Uye GetElementById(int id)
        {
            {
                var searchingOne = _uyeRepository.GetAllUyeler().FirstOrDefault(s => id == s.UyeId);
                return searchingOne;
            }
        }
    }
}