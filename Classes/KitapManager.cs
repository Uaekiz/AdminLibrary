using AdminKütüphane.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKütüphane.Classes
{
    internal class KitapManager
    {
        private KitapRepository _kitapRepository;
        public KitapManager()
        {
            _kitapRepository = new KitapRepository();
        }

        public List<Kitap> GetTumKitaplar()
        {
            return _kitapRepository.GetAllKitaplar();
        }

        public List<Kitap> FindKitap(string input)
        {
            var bulunanKitaplar = new List<Kitap>();
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            var tumKitaplar = _kitapRepository.GetAllKitaplar();
            foreach (var kitap in tumKitaplar)
            {
                if (kitap.KitapAdi.ToLower().Contains(input.ToLower()) || kitap.ISBN.ToString().Contains(input))
                {
                    bulunanKitaplar.Add(kitap);
                }
            }
            return bulunanKitaplar;
        }
    }
}
