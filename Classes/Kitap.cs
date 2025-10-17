using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKütüphane.Classes
{
    internal class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int ISBN { get; set; }
        public bool Bulunma { get; set; }

        public Kitap() { }
    }
}
