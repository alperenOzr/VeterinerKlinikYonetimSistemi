using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerKlinikYonetimSistemi;

public partial class GuncelleForm : Form
{
    private int dataS = 0;
    private int id = -1;
    private List<TextBox> textBoxList = [];
    private List<ComboBox> comboBoxList = [];
    private List<RadioButton> radioButtonList = [];
    private List<DateTimePicker> dateTimePickerList = [];
    int topPosition = 20;
    readonly string sqlString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

    public GuncelleForm(int dataSource, int idComeFrom)
    {
        InitializeComponent();

        switch (dataSource)
        {
            //Hayvan sahipleri için
            case 1:
                this.Text = "Hayvan Sahibi Güncelle";
                BaslikVeTextBoxOlustur(4,
                    ["İsim",
                        "Soyisim",
                        "Adres",
                        "Telefon"]);
                break;
            //Hayvanlar için
            case 2:
                this.Text = "Hayvan Güncelle";
                BaslikVeTextBoxOlustur(4,
                    ["İsim",
                        "Tur",
                        "Cins",
                        "Yas"]);
                BaslikVeRadioButtonOlustur(1,
                    ["Evcil"]);
                BaslikVeComboBoxOlustur(2,
                    ["Sahibi",
                        "Klinik"]);
                break;
            //Klinikler için
            case 3:
                this.Text = "Klinik Güncelle";
                List<string> labelList2 =
                    ["İsim",
                        "Adres",
                        "Telefon"];
                BaslikVeTextBoxOlustur(3, labelList2);
                break;
            case 4:
                this.Text = "Muayene Güncelle";
                BaslikVeComboBoxOlustur(1, ["Sahibi"]);
                BaslikVeComboBoxOlustur(2, ["Hayvan", "Klinik"]);
                BaslikVeTextBoxOlustur(2, ["Y. İşlem", "Notlar"]);
                BaslikVeDateTimePickerOlustur("Tarih");
                int toplamElemanSayisi = 0;
                break;
            default:
                break;
        }
        this.id = idComeFrom;
        this.dataS = dataSource;
        BoxlariDoldur();
        ButonlariOlustur();
    }

    private void BaslikVeTextBoxOlustur(int count, List<string> labelList)
    { 
        for (int i = 1; i <= count; i++)
        {
            Label label = new()
            {
                Text = labelList[i - 1],
                Location = new Point(20, this.topPosition),
                AutoSize = true
            };

            TextBox textBox = new()
            {
                Location = new Point(100, this.topPosition),
                Width = 200
            };
            textBoxList.Add(textBox); // TextBox'ı listeye ekle

            this.Controls.Add(label);
            this.Controls.Add(textBox);

            this.topPosition += 40; // Yükseklik aralığı
        }
    }

    private void BaslikVeComboBoxOlustur(int count, List<string> labelList)
    {
        for (int i = 1; i <= count; i++)
        {
            Label label = new()
            {
                Text = labelList[i - 1],
                Location = new Point(20, this.topPosition),
                AutoSize = true
            };

            ComboBox comboBox = new()
            {
                Location = new Point(100, this.topPosition),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList // Sadece seçim yapılabilir hale getiriyoruz
            };

            comboBoxList.Add(comboBox);

            this.Controls.Add(label);
            this.Controls.Add(comboBox);

            this.topPosition += 40; 
        }
    }

    private void BaslikVeRadioButtonOlustur(int count, List<string> labelList)
    {
        for (int i = 1; i <= count; i++)
        {
            Label label = new()
            {
                Text = labelList[i - 1],
                Location = new Point(20, this.topPosition),
                AutoSize = true
            };
            RadioButton radioButton = new()
            {
                Location = new Point(100, this.topPosition),
                Width = 200
            };
            radioButtonList.Add(radioButton);
            // Yeni Label ve TextBox'ı forma ekle
            this.Controls.Add(label);
            this.Controls.Add(radioButton);

            // Sonraki öğeler için pozisyonu güncelle
            this.topPosition += 40; // Yükseklik aralığı
        }
    }

    private void BaslikVeDateTimePickerOlustur(string baslik)
    {
        // Label oluştur
        Label label = new()
        {
            Text = baslik,
            Location = new Point(20, this.topPosition),
            AutoSize = true
        };

        // DateTimePicker oluştur
        DateTimePicker dateTimePicker = new()
        {
            Location = new Point(100, this.topPosition),
            Width = 200,
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "yyyy-MM-dd HH:mm:ss" // İstediğiniz tarih formatı
        };

        dateTimePickerList.Add(dateTimePicker); // DateTimePicker'ı listeye ekle

        this.Controls.Add(label);
        this.Controls.Add(dateTimePicker);

        this.topPosition += 40; // Yükseklik aralığı

    }

    private void ButonlariOlustur()
    {
        // Tamam butonu
        Button btnOk = new()
        {
            Text = "Güncelle",
            Location = new Point(100, this.topPosition),
            Width = 100,
            Height = 35
        };
        btnOk.Click += BtnOk_Click;

        // İptal butonu
        Button btnCancel = new()
        {
            Text = "İptal",
            Location = new Point(200, this.topPosition),
            Width = 100,
            Height = 35
        };
        btnCancel.Click += BtnCancel_Click;

        // Butonları forma ekle
        this.Controls.Add(btnOk);
        this.Controls.Add(btnCancel);
    }

    private void BtnOk_Click(object? sender, EventArgs e)
    {
        // Verileri al ve ekle
        Guncelle(dataS, id);
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void BoxlariDoldur()
    {
        switch (dataS)
        {
            case 1:
                SqlConnection con = new(sqlString);
                con.Open();
                SqlCommand cmd = new("SELECT Isim, Soyisim, Adres, Telefon FROM Sahipler WHERE SahipID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                Sahipler hayvanSahibi = new();
                while (dr.Read())
                {
                    hayvanSahibi = new()
                    {
                        Isim = dr["Isim"].ToString(),
                        Soyisim = dr["Soyisim"].ToString(),
                        Adres = dr["Adres"].ToString(),
                        Telefon = dr["Telefon"].ToString()
                    };

                }
                con.Close();
                textBoxList[0].Text = hayvanSahibi.Isim;
                textBoxList[1].Text = hayvanSahibi.Soyisim;
                textBoxList[2].Text = hayvanSahibi.Adres;
                textBoxList[3].Text = hayvanSahibi.Telefon;
                break;
            case 2:
                SqlConnection con1 = new(sqlString);
                con1.Open();
                SqlCommand cmd1 = new("SELECT Isim, Tur, Cins, Yas, EvcilMi, SahipID, KlinikID FROM Hayvanlar WHERE HayvanID = @Id", con1);
                cmd1.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                Hayvanlar hayvan = new();
                int sahipId = 0;
                int klinikId = 0;

                while (dr1.Read())
                {
                    hayvan = new()
                    {
                        EvcilMi = Convert.ToBoolean(dr1["EvcilMi"]),
                        Isim = dr1["Isim"].ToString(),
                        Tur = dr1["Tur"].ToString(),
                        Cins = dr1["Cins"].ToString(),
                        Yas = Convert.ToInt32(dr1["Yas"])
                    };
                    sahipId = dr1["SahipID"] != DBNull.Value ? Convert.ToInt32(dr1["SahipID"]) : 0;
                    klinikId = dr1["KlinikID"] != DBNull.Value ? Convert.ToInt32(dr1["KlinikID"]) : 0;
                }
                con1.Close();
                textBoxList[0].Text = hayvan.Isim;
                textBoxList[1].Text = hayvan.Tur;
                textBoxList[2].Text = hayvan.Cins;
                textBoxList[3].Text = hayvan.Yas.ToString();
                if (hayvan.EvcilMi) {
                    radioButtonList[0].Checked = true;
                } else {
                    radioButtonList[0].Checked = false;
                }
                HayvanSahipleriniYukle(comboBoxList[0]);
                KlinikleriYukle(comboBoxList[1]);

                comboBoxList[0].SelectedValue = sahipId; // Sahip ID'sine göre seçili yap
                comboBoxList[1].SelectedValue = klinikId; // Klinik ID'sine göre seçili 
                break;
            case 3:
                SqlConnection con2 = new(sqlString);
                con2.Open();
                SqlCommand cmd2 = new("SELECT Isim, Adres, Telefon FROM Klinikler WHERE KlinikID = @Id", con2);
                cmd2.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                Klinik klinik = new();
                while (dr2.Read())
                {
                    klinik = new()
                    {
                        Isim = dr2["Isim"].ToString(),
                        Adres = dr2["Adres"].ToString(),
                        Telefon = dr2["Telefon"].ToString(),
                    };
                }
                con2.Close();
                textBoxList[0].Text = klinik.Isim;
                textBoxList[1].Text = klinik.Adres;
                textBoxList[2].Text = klinik.Telefon;
                break;
            case 4:
                SqlConnection con3 = new(sqlString);
                con3.Open();
                SqlCommand cmd3 = new(@"SELECT MuayeneID, HayvanID, SahipID, KlinikID, Tarih, YapilanIslemler, Notlar 
                            FROM Muayeneler WHERE MuayeneID = @Id", con3);
                cmd3.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                MuayeneGuncelle muayene = new();
                int sahipId1 = 0;
                int klinikId1 = 0;
                int hayvanId = 0;

                while (dr3.Read())
                {
                    muayene = new()
                    {
                        Id = dr3["MuayeneID"] != DBNull.Value ? Convert.ToInt32(dr3["MuayeneID"]) : 0,
                        YapilanIslemler = (string)(dr3["YapilanIslemler"] != DBNull.Value ? dr3["YapilanIslemler"] : "-"),
                        Notlar = (string)(dr3["Notlar"] != DBNull.Value ? dr3["Notlar"] : "-"),
                        Tarih = dr3["Tarih"] != DBNull.Value ? Convert.ToDateTime(dr3["Tarih"]) : default(DateTime) // Eğer Tarih NULL ise default(DateTime) atanır
                    };

                    sahipId1 = dr3["SahipID"] != DBNull.Value ? Convert.ToInt32(dr3["SahipID"]) : 0;
                    klinikId1 = dr3["KlinikID"] != DBNull.Value ? Convert.ToInt32(dr3["KlinikID"]) : 0;
                    hayvanId = dr3["HayvanID"] != DBNull.Value ? Convert.ToInt32(dr3["HayvanID"]) : 0;
                }
                con3.Close();

                HayvanSahipleriniYukle(comboBoxList[0]);
                HayvanlariYukle(comboBoxList[1], muayene.Id); // Düzeltme: Doğru parametre ile çağırma
                KlinikleriYukle(comboBoxList[2]);
                
                comboBoxList[0].SelectedValue = sahipId1;
                comboBoxList[1].SelectedValue = hayvanId;
                comboBoxList[2].SelectedValue = klinikId1;

                comboBoxList[0].Refresh();
                comboBoxList[1].Refresh();
                comboBoxList[2].Refresh();

                comboBoxList[0].Enabled = false;
                comboBoxList[1].Enabled = false;

                textBoxList[0].Text = muayene.YapilanIslemler;
                textBoxList[1].Text = muayene.Notlar;
                dateTimePickerList[0].Value = muayene.Tarih;
                break;

        }
    }

    private void Guncelle(int ds, int id)
    {
        switch (ds)
        {
            case 1:
                // TextBox'ların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(textBoxList[0].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[1].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[2].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[3].Text))
                {
                    MessageBox.Show("Güncelleme için tüm alanların doldurulması gerekiyor.");
                    return;
                }

                using (SqlConnection con = new(sqlString))
                {
                    con.Open();
                    string query = @"
                            UPDATE Sahipler
                            SET Isim = @Isim,
                                Soyisim = @Soyisim,
                                Adres = @Adres,
                                Telefon = @Telefon
                            WHERE SahipId = @Id";

                    using SqlCommand cmd = new(query, con);
                    cmd.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                    cmd.Parameters.AddWithValue("@Soyisim", textBoxList[1].Text);
                    cmd.Parameters.AddWithValue("@Adres", textBoxList[2].Text);
                    cmd.Parameters.AddWithValue("@Telefon", textBoxList[3].Text);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0){
                        MessageBox.Show("Güncelleme başarılı!");
                    } else {
                        MessageBox.Show("Güncelleme işlemi başarısız.");
                    }
                }
                break;
            case 2:
                // TextBox'ların ve diğer kontrol elemanlarının boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(textBoxList[0].Text) || // Isim
                    string.IsNullOrWhiteSpace(textBoxList[1].Text) || // Tur
                    string.IsNullOrWhiteSpace(textBoxList[2].Text) || // Cins
                    string.IsNullOrWhiteSpace(textBoxList[3].Text))   // Yas
                {
                    MessageBox.Show("Güncelleme için gerekli alanların doldurulması gerekiyor.");
                    return;
                }

                using (SqlConnection con1 = new(sqlString))
                {
                    con1.Open();

                    // 1. Hayvanlar tablosunu güncelle
                    string queryHayvanlar = @"
                        UPDATE Hayvanlar
                        SET Isim = @Isim,
                            Tur = @Tur,
                            Cins = @Cins,
                            Yas = @Yas,
                            EvcilMi = @EvcilMi,
                            SahipID = @SahipID,
                            KlinikID = @KlinikID
                        WHERE HayvanID = @Id";

                    using (SqlCommand cmdHayvanlar = new(queryHayvanlar, con1))
                    {
                        // Parametreleri ekle
                        cmdHayvanlar.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                        cmdHayvanlar.Parameters.AddWithValue("@Tur", textBoxList[1].Text);
                        cmdHayvanlar.Parameters.AddWithValue("@Cins", textBoxList[2].Text);
                        cmdHayvanlar.Parameters.AddWithValue("@Yas", Convert.ToInt32(textBoxList[3].Text));
                        cmdHayvanlar.Parameters.AddWithValue("@EvcilMi", radioButtonList[0].Checked); // EvcilMi radiobutton
                        cmdHayvanlar.Parameters.AddWithValue("@SahipID", comboBoxList[0].SelectedValue ?? DBNull.Value); // Sahip ID
                        cmdHayvanlar.Parameters.AddWithValue("@KlinikID", comboBoxList[1].SelectedValue ?? DBNull.Value); // Klinik ID
                        cmdHayvanlar.Parameters.AddWithValue("@Id", id); // Güncellenecek hayvanın ID'si

                        int rowsAffected = cmdHayvanlar.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hayvanlar tablosu güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Hayvanlar tablosunda güncelleme yapılamadı.");
                            return;
                        }
                    }

                    // 2. Muayeneler tablosunu güncelle
                    string queryMuayeneler = @"
                          UPDATE Muayeneler
                          SET KlinikID = (
                              SELECT KlinikID 
                              FROM Hayvanlar 
                              WHERE Hayvanlar.HayvanID = Muayeneler.HayvanID
                          )
                          WHERE HayvanID = @Id";

                    using SqlCommand cmdMuayeneler = new(queryMuayeneler, con1);
                    // Parametreyi ekle
                    cmdMuayeneler.Parameters.AddWithValue("@Id", id); // Güncellenecek hayvanın ID'si

                    int rowsAffectedMuayeneler = cmdMuayeneler.ExecuteNonQuery();

                    if (rowsAffectedMuayeneler > 0)
                    {
                        MessageBox.Show("Muayeneler tablosu güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Muayeneler tablosunda güncelleme yapılamadı.");
                    }
                }
                break;
            case 3:
                // TextBox'ların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(textBoxList[0].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[1].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[2].Text))
                {
                    MessageBox.Show("Güncelleme için tüm alanların doldurulması gerekiyor.");
                    return;
                }
                // Güncelleme işlemi
                using (SqlConnection con2 = new(sqlString))
                {
                    con2.Open();
                    string query = @"
                            UPDATE Klinikler
                            SET Isim = @Isim,
                                Adres = @Adres,
                                Telefon = @Telefon
                            WHERE KlinikID = @Id";

                    using SqlCommand cmd2 = new(query, con2);
                    cmd2.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                    cmd2.Parameters.AddWithValue("@Adres", textBoxList[1].Text);
                    cmd2.Parameters.AddWithValue("@Telefon", textBoxList[2].Text);
                    cmd2.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd2.ExecuteNonQuery();

                    if (rowsAffected > 0) {
                        MessageBox.Show("Güncelleme başarılı!");
                    } else {
                        MessageBox.Show("Güncelleme işlemi başarısız.");
                    }
                }
                break;
            case 4:
                if (string.IsNullOrWhiteSpace(textBoxList[0].Text) ||
                    string.IsNullOrWhiteSpace(textBoxList[1].Text))


                {
                    MessageBox.Show("Güncelleme için gerekli alanların doldurulması gerekiyor.");
                    return;
                }

                // Tarih kontrolü
                /* (!DateTime.TryParse(textBoxList[6].Text, out DateTime tarih))
                {
                    MessageBox.Show("Geçerli bir tarih formatı giriniz. Örn: 2025-01-01");
                    return;
                }
                */
                using (SqlConnection con3 = new(sqlString))
                {
                    con3.Open();

                    // Muayeneler tablosunu güncelleme sorgusu
                    string queryMuayeneler = @"
                        UPDATE Muayeneler
                        SET 
                            Tarih = @Tarih,
                            YapilanIslemler = @YapilanIslemler,
                            Notlar = @Notlar
                        WHERE MuayeneID = @MuayeneID";

                    using SqlCommand cmdMuayeneler = new(queryMuayeneler, con3);
                    // Parametreleri ekle
                    //   cmdMuayeneler.Parameters.AddWithValue("@Tarih", tarih); // Doğrulanan tarih
                    cmdMuayeneler.Parameters.AddWithValue("@YapilanIslemler", textBoxList[0].Text); // Yapılan İşlemler
                    cmdMuayeneler.Parameters.AddWithValue("@Notlar", textBoxList[1].Text); // 
                    cmdMuayeneler.Parameters.AddWithValue("@MuayeneID", id); // Güncellenecek Muayene'nin ID'si
                    cmdMuayeneler.Parameters.AddWithValue("@Tarih", dateTimePickerList[0].Value.ToString("yyyy-MM-dd HH:mm:ss.fff")); // Güncellenecek Muayene'nin ID'si

                    // Sorguyu çalıştır
                    int rowsAffected = cmdMuayeneler.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Muayeneler tablosu başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Muayeneler tablosunda güncelleme yapılamadı.");
                    }
                }
                break;
        }
    }

    private static void HayvanSahipleriniYukle(ComboBox comboBox)
    {
        string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";
        string query = "SELECT SahipId, CONCAT(Isim, ' ', Soyisim, ' - ', Telefon) AS Sahip FROM Sahipler";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(query, connection);
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new();
            dataTable.Load(reader);

            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "SahipId";
            comboBox.DisplayMember = "Sahip";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanı hatası: " + ex.Message);
        }
    }

    private static void KlinikleriYukle(ComboBox comboBox)
    {
        string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";
        string query = "SELECT KlinikId, Isim FROM Klinikler";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(query, connection);
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new();
            dataTable.Load(reader);

            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "KlinikId"; // Arka planda ID tutulacak
            comboBox.DisplayMember = "Isim"; // Görünen değer
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanı hatası: " + ex.Message);
        }
    }

    private void HayvanlariYukle(ComboBox comboBox, int MuayeneID)
    {
        //MessageBox.Show(MuayeneID.ToString());
        string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";
        string query = "SELECT HayvanID, Isim FROM Hayvanlar WHERE SahipID = (SELECT SahipID FROM Muayeneler WHERE MuayeneID = @MuayeneID)";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(query, connection);
        try
        {
            connection.Open();

            // Parametreyi doğru şekilde ekle
            command.Parameters.AddWithValue("@MuayeneID", MuayeneID);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new();
            dataTable.Load(reader);

            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "HayvanID"; // Arka planda ID tutulacak
            comboBox.DisplayMember = "Isim";   // Görünen değer
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
