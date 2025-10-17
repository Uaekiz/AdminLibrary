using AdminKütüphane.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKütüphane.DAL
{
    internal class KitapRepository
    {
        private const string KitapFilePath = "Datas/Kitaplar.txt";

        public List<Kitap> GetAllKitaplar()
        {
            var kitaplar = new List<Kitap>();
            if (!File.Exists(KitapFilePath))
            {
                return kitaplar;
            }

            var satirlar = File.ReadAllLines(KitapFilePath, Encoding.UTF8);

            foreach (var satir in satirlar)
            {
                if (string.IsNullOrWhiteSpace(satir)) continue;

                var parcalar = satir.Split(';');
                if (parcalar.Length < 4) continue;
                var kitap = new Kitap
                {
                    KitapAdi = parcalar[0],
                    YazarAdi = parcalar[1],
                    ISBN = int.TryParse(parcalar[2], out int isbn) ? isbn : 0,
                    Bulunma = bool.TryParse(parcalar[3], out bool bulunma) ? bulunma : false
                };
                kitaplar.Add(kitap);
            }

            return kitaplar;
        }
    }
}
