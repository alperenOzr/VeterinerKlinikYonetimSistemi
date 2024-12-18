using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        UserControl? acikUserControl;

        private void SahipListeleBtn_Click(object sender, EventArgs e)
        {
            if (acikUserControl == hsList)
            {
                return;
            }

            SqlConnection con = new(sqlString);
            con.Open();
            List<Sahipler> hayvanSahipleri = [];
            SqlCommand cmd = new("SELECT * FROM Sahipler", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir satýr için yeni bir Sahipler nesnesi oluþturuyoruz
                Sahipler hayvanSahibi = new()
                {
                    SahipID = Convert.ToInt32(dr["SahipID"]),
                    Isim = dr["Isim"].ToString(),
                    Soyisim = dr["Soyisim"].ToString(),
                    Telefon = dr["Telefon"].ToString(),
                    KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"])
                };
                // Listeye ekliyoruz
                hayvanSahipleri.Add(hayvanSahibi);
            }
            con.Close();
            hsList.dataGridView1.DataSource = hayvanSahipleri;

            AcikOlaniKapat();
            hsList.Visible = true;
            acikUserControl = hsList;
        }

        private void HayvanListeleBtn_Click(object sender, EventArgs e)
        {
            if (acikUserControl == hList)
            {
                return;
            }

            SqlConnection con = new(sqlString);
            con.Open();
            List<Hayvanlar> hayvanlarListe = [];
            SqlCommand cmd = new("SELECT * FROM Hayvanlar", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir satýr için yeni bir Sahipler nesnesi oluþturuyoruz
                Hayvanlar hayvan = new()
                {
                    Id = Convert.ToInt32(dr["HayvanId"]),
                    Isim = dr["Isim"].ToString(),
                    Tur = dr["Tur"].ToString(),
                    Cins = dr["Cins"].ToString(),
                    Yas = Convert.ToInt32(dr["Yas"]),
                    EvcilMi = Convert.ToBoolean(dr["EvcilMi"]),
                    SahipID = dr["SahipID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["SahipID"]),
                    KlinikID = dr["KlinikID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["KlinikID"]),
                };
                // Listeye ekliyoruz
                hayvanlarListe.Add(hayvan);
            }
            con.Close();
            hList.dataGridView1.DataSource = hayvanlarListe;

            AcikOlaniKapat();
            hList.Visible = true;
            acikUserControl = hList;
        }

        private void KlinikListeleBtn_Click(object sender, EventArgs e)
        {
            if (acikUserControl == kList)
            {
                return;
            }

            SqlConnection con = new(sqlString);
            con.Open();
            List<Klinik> klinikListe = [];
            SqlCommand cmd = new("SELECT * FROM Klinikler", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir satýr için yeni bir Sahipler nesnesi oluþturuyoruz
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
            kList.dataGridView1.DataSource = klinikListe;

            AcikOlaniKapat();
            kList.Visible = true;
            acikUserControl = kList;
        }

        private void MuayeneleriListeleBtn_Click(object sender, EventArgs e)
        {
            if(acikUserControl == mList)
            {
                return;
            }

            SqlConnection con = new(sqlString);
            con.Open();
            List<Muayene> MuayeneListe = [];
            SqlCommand cmd = new("SELECT * FROM Muayeneler", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Her bir satýr için yeni bir Sahipler nesnesi oluþturuyoruz
                Muayene muayene = new()
                {
                    Id = Convert.ToInt32(dr["MuayeneID"]),
                    HayvanId = Convert.ToInt32(dr["HayvanID"]),
                    KlinikId = Convert.ToInt32(dr["KlinikID"]),
                    Tarih = Convert.ToDateTime(dr["Tarih"]),
                    YapilanIslemler = (dr["YapilanIslemler"]).ToString(),
                    Notlar = (dr["Notlar"]).ToString()
                };
                // Listeye ekliyoruz
                MuayeneListe.Add(muayene);
            }
            con.Close();
            mList.dataGridView1.DataSource = MuayeneListe;

            AcikOlaniKapat();
            mList.Visible = true;
            acikUserControl = mList;
        }

        private void AcikOlaniKapat()
        {
            if (acikUserControl != null)
            {
                acikUserControl.Visible = false;
            }
        }

        
    }
}
