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
    }
}
