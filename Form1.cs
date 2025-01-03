using Microsoft.Data.SqlClient;

namespace VeterinerKlinikYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string sqlString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";
        int dataSource = 0;

        private void SahipListeleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(sqlString);
            con.Open();
            List<Sahipler> hayvanSahipleri = [];
            SqlCommand cmd = new("SELECT * FROM Sahipler", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir sat�r i�in yeni bir Sahipler nesnesi olu�turuyoruz
                Sahipler hayvanSahibi = new()
                {
                    SahipID = Convert.ToInt32(dr["SahipID"]),
                    Isim = dr["Isim"].ToString(),
                    Soyisim = dr["Soyisim"].ToString(),
                    Adres = dr["Adres"].ToString(),
                    Telefon = dr["Telefon"].ToString(),
                    KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"])
                };
                // Listeye ekliyoruz
                hayvanSahipleri.Add(hayvanSahibi);
            }
            con.Close();
            dataGridView1.DataSource = hayvanSahipleri;
            dataSource = 1;
            dataGridPnl.Visible = true;
        }

        private void HayvanListeleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(sqlString);
            con.Open();
            List<Hayvanlar> hayvanlarListe = [];
            SqlCommand cmd = new(@"
            SELECT 
                h.HayvanId,
                h.Isim,
                h.Tur,
                h.Cins, 
                h.Yas, 
                h.EvcilMi, 
                h.SahipID, 
                h.KlinikID, 
                s.Isim AS SahipAd,
                s.Telefon AS SahipTelefon,
                k.Isim AS KlinikAd
            FROM 
                Hayvanlar h
            LEFT JOIN 
                Sahipler s ON h.SahipID = s.SahipID
            LEFT JOIN 
                Klinikler k ON h.KlinikID = k.KlinikID", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hayvanlar hayvan = new()
                {
                    Id = Convert.ToInt32(dr["HayvanId"]),
                    Isim = dr["Isim"].ToString(),
                    Tur = dr["Tur"].ToString(),
                    Cins = dr["Cins"].ToString(),
                    Yas = Convert.ToInt32(dr["Yas"]),
                    EvcilMi = Convert.ToBoolean(dr["EvcilMi"]),
                    SahipAd = dr["SahipAd"].ToString(),
                    SahipTelefon = dr["SahipTelefon"].ToString(),
                    KlinikAd = dr["KlinikAd"].ToString()
                };
                hayvanlarListe.Add(hayvan);
            }
            con.Close();
            dataGridView1.DataSource = hayvanlarListe;
            dataSource = 2;
            dataGridPnl.Visible = true;
        }

        private void KlinikListeleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(sqlString);
            con.Open();
            List<Klinik> klinikListe = [];
            SqlCommand cmd = new("SELECT * FROM Klinikler", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir sat�r i�in yeni bir Sahipler nesnesi olu�turuyoruz
                Klinik klinik = new()
                {
                    Id = Convert.ToInt32(dr["KlinikID"]),
                    Isim = dr["Isim"].ToString(),
                    Adres = dr["Adres"].ToString(),
                    Telefon = dr["Telefon"].ToString(),
                    BakilanHayvan = Convert.ToInt32(dr["ToplamBakilanHayvanSayisi"]),
                };
                // Listeye ekliyoruz
                klinikListe.Add(klinik);
            }
            con.Close();
            dataGridView1.DataSource = klinikListe;
            dataSource = 3;
            dataGridPnl.Visible = true;
        }

        private void MuayeneleriListeleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(sqlString);
            con.Open();
            List<Muayene> MuayeneListe = [];
            SqlCommand cmd = new(
            @"SELECT 
                m.MuayeneId, 
                m.Tarih AS MuayeneTarihi, 
                h.Isim AS HayvanIsmi,
                h.Tur AS HayvanTuru,
                h.Cins AS HayvanCinsi,
                s.Isim AS SahipIsmi,
                s.Telefon AS SahipTelefon,
                k.Isim AS KlinikAdi,
                m.YapilanIslemler,
                m.Notlar
            FROM 
                muayeneler m
            LEFT JOIN 
                hayvanlar h ON m.HayvanId = h.HayvanId
            LEFT JOIN 
                sahipler s ON h.SahipId = s.SahipID
            LEFT JOIN 
                klinikler k ON m.KlinikId = k.KlinikID
            ORDER BY 
                m.Tarih DESC;", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Muayene muayene = new()
                {
                    Id = dr["MuayeneId"] != DBNull.Value ? Convert.ToInt32(dr["MuayeneId"]) : 0,
                    Tarih = dr["MuayeneTarihi"] != DBNull.Value ? Convert.ToDateTime(dr["MuayeneTarihi"]) : default(DateTime),
                    YapilanIslemler = dr["YapilanIslemler"] != DBNull.Value ? dr["YapilanIslemler"].ToString() : "-",
                    Notlar = dr["Notlar"] != DBNull.Value ? dr["Notlar"].ToString() : "-",
                    HayvanIsim = dr["HayvanIsmi"] != DBNull.Value ? dr["HayvanIsmi"].ToString() : "-",
                    HayvanTur = dr["HayvanTuru"] != DBNull.Value ? dr["HayvanTuru"].ToString() : "-",
                    HayvanCins = dr["HayvanCinsi"] != DBNull.Value ? dr["HayvanCinsi"].ToString() : "-",
                    HayvanSahibi = dr["SahipIsmi"] != DBNull.Value ? dr["SahipIsmi"].ToString() : "-",
                    HayvanSahibiTel = dr["SahipTelefon"] != DBNull.Value ? dr["SahipTelefon"].ToString() : "-"
                };
                MuayeneListe.Add(muayene);
            }
            con.Close();
            dataGridView1.DataSource = MuayeneListe;
            dataSource = 4;
            dataGridPnl.Visible = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        }

        private void SilSorgusu(int dataTablosu, int id)
        {
            using SqlConnection con = new(sqlString);
            con.Open();

            switch (dataTablosu)
            {
                case 1: // Sahipler tablosu
                    SqlCommand sahipSilCmd = new("DELETE FROM Sahipler WHERE SahipID = @Id", con);
                    sahipSilCmd.Parameters.AddWithValue("@Id", id);
                    sahipSilCmd.ExecuteNonQuery();
                    MessageBox.Show($"Sahip ID {id} ba�ar�yla silindi.");
                    break;

                case 2: // Hayvanlar tablosu
                    SqlCommand muayeneSilCmd1 = new("DELETE FROM Muayeneler WHERE HayvanID = @Id", con);
                    muayeneSilCmd1.Parameters.AddWithValue("@Id", id);
                    muayeneSilCmd1.ExecuteNonQuery();

                    SqlCommand hayvanSilCmd = new("DELETE FROM Hayvanlar WHERE HayvanID = @Id", con);
                    hayvanSilCmd.Parameters.AddWithValue("@Id", id);
                    hayvanSilCmd.ExecuteNonQuery();
                    MessageBox.Show($"Hayvan ID {id} ba�ar�yla silindi.");
                    break;
                case 3: // Klinikler tablosu
                    try
                    {
                        // Klinik ba�ka tablolarda kullan�l�yor mu kontrol et
                        SqlCommand kontrolCmd = new(@"SELECT COUNT(*) 
                                      FROM Hayvanlar 
                                      WHERE KlinikID = @Id", con);
                        kontrolCmd.Parameters.AddWithValue("@Id", id);
                        int hayvanKaydi = (int)kontrolCmd.ExecuteScalar();

                        kontrolCmd.CommandText = @"SELECT COUNT(*) 
                                   FROM Muayeneler 
                                   WHERE KlinikID = @Id";
                        int muayeneKaydi = (int)kontrolCmd.ExecuteScalar();

                        if (hayvanKaydi > 0 || muayeneKaydi > 0)
                        {
                            SqlCommand hayvanKaydiNullYap = new(@"UPDATE Hayvanlar SET KlinikID = NULL WHERE KlinikID = @Id", con);
                            hayvanKaydiNullYap.Parameters.AddWithValue("@Id", id);
                            hayvanKaydiNullYap.ExecuteNonQuery();

                            SqlCommand muayeneKaydiNullYap = new(@"UPDATE Muayeneler SET KlinikID = NULL WHERE KlinikID = @Id", con);
                            muayeneKaydiNullYap.Parameters.AddWithValue("@Id", id);
                            muayeneKaydiNullYap.ExecuteNonQuery();
                        }
                        // Hi�bir ili�ki yoksa silme i�lemini ger�ekle�tir
                        SqlCommand klinikSilCmd = new("DELETE FROM Klinikler WHERE KlinikID = @Id", con);
                        klinikSilCmd.Parameters.AddWithValue("@Id", id);
                        klinikSilCmd.ExecuteNonQuery();
                        MessageBox.Show($"Klinik ID {id} ba�ar�yla silindi.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Silme i�lemi s�ras�nda bir hata olu�tu: {ex.Message}");
                    }
                    break;

                case 4: // Muayeneler tablosu
                    SqlCommand muayeneSilCmd = new("DELETE FROM Muayeneler WHERE MuayeneID = @Id", con);
                    muayeneSilCmd.Parameters.AddWithValue("@Id", id);
                    muayeneSilCmd.ExecuteNonQuery();
                    MessageBox.Show($"Muayene ID {id} ba�ar�yla silindi.");
                    break;

                default:
                    MessageBox.Show("Ge�ersiz tablo se�imi!");
                    return;
            }

            // Tabloyu yenile
            YenileTablo();
        }

        private void YenileTablo()
        {
            switch (dataSource)
            {
                case 1:
                    SahipListeleBtn_Click(null, null); // Sahipleri yeniden listele
                    break;
                case 2:
                    HayvanListeleBtn_Click(null, null); // Hayvanlar� yeniden listele
                    break;
                case 3:
                    KlinikListeleBtn_Click(null, null); // Klinikleri yeniden listele
                    break;
                case 4:
                    MuayeneleriListeleBtn_Click(null, null); // Muayeneleri yeniden listele
                    break;
                default:
                    break;
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Do�rulama mesaj�
                DialogResult result = MessageBox.Show(
                    $"Se�ili ID: {selectedId} silmek istedi�inize emin misiniz?",
                    "Silme Onay�",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SilSorgusu(dataSource, selectedId);
                }
                else
                {
                    _ = MessageBox.Show("Silme i�lemi iptal edildi.");
                }
            }
            else
            {
                _ = MessageBox.Show("L�tfen silmek istedi�iniz bir sat�r se�in!");
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if(dataSource != 0) {
                MessageBoxForm Ekle = new(dataSource);
                Ekle.ShowDialog();
                YenileTablo();
            } else {
                _ = MessageBox.Show("Ge�erli Bir Tablo Se�iniz!");
            }

        }
    }
}
