using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinikYonetimSistemi
{
    public class Sahipler
    {
        public int SahipID { get; set; }
        public string? Isim { get; set; }
        public string? Soyisim { get; set; }
        public string? Telefon { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
