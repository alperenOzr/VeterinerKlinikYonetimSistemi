using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinikYonetimSistemi
{
    public class Klinik
    {
        public int Id { get; set; }
        public string? Isim { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public int BakilanHayvan { get; set; }
    }
}