namespace VeterinerKlinikYonetimSistemi
{
    public class Muayene
    {
        public int Id { get; set; }
        public string? HayvanIsim { get; set; }
        public string? HayvanTur {  get; set; }
        public string? HayvanCins { get; set; }
        public string? HayvanSahibi { get; set; }
        public string? HayvanSahibiTel { get; set; }
        public DateTime Tarih { get; set; }
        public string? YapilanIslemler { get; set; }
        public string? Notlar { get; set; }
    }
}