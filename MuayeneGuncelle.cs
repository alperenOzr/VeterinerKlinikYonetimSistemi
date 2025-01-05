using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinikYonetimSistemi;

public class MuayeneGuncelle
{
    public int Id { get; set; }
    public DateTime Tarih { get; set; }
    public string? YapilanIslemler { get; set; }
    public string? Notlar { get; set; }
}
