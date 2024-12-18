using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinikYonetimSistemi
{
    public class Muayene
    {
        public int Id { get; set; }
        public int HayvanId { get; set; }
        public int KlinikId { get; set; }
        public DateTime Tarih { get; set; }
        public string? YapilanIslemler { get; set; }
        public string? Notlar { get; set; }
    }
}