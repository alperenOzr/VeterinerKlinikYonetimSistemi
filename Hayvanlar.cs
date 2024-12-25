using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinikYonetimSistemi
{
    public class Hayvanlar
    {
        public int Id { get; set; }
        public string? Isim { get; set; }
        public string? Tur { get; set; }
        public string? Cins { get; set; }
        public int Yas { get; set; }
        public bool EvcilMi { get; set; }
        public string? SahipAd { get; set; } // Yeni alan
        public string? SahipTelefon { get; set; } // Yeni alan
        public string? KlinikAd { get; set; } // Yeni alan
    }
}