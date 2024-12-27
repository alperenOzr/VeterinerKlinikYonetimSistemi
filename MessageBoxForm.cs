using Microsoft.Data.SqlClient;
using System.Data;

namespace VeterinerKlinikYonetimSistemi
{
    public partial class MessageBoxForm : Form
    {
        private int dataS = 0;
        private List<TextBox> textBoxList = [];
        private List<ComboBox> comboBoxList = [];
        private List<RadioButton> radioButtonList = [];
        int topPosition = 20;

        public MessageBoxForm(int dataSource)
        {
            InitializeComponent();

            switch (dataSource)
            {
                //Hayvan sahipleri için
                case 1:
                    this.Text = "Hayvan Sahibi Ekle";
                    BaslikVeTextBoxOlustur(4, 
                        ["İsim",
                        "Soyisim",
                        "Telefon",
                        "Adres"]);
                    break;
                //Hayvanlar için
                case 2:
                    this.Text = "Hayvan Ekle";
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
                    this.Text = "Klinik Ekle";
                    List<string> labelList2 =
                        ["İsim",
                        "Adres",
                        "Telefon"];
                    BaslikVeTextBoxOlustur(3, labelList2);
                    break;
                case 4:
                    this.Text = "Muayene Ekle";
                    break;
                default:
                    break;
            }
            ButonlariOlustur();
            this.dataS = dataSource;
        }

        private void BaslikVeTextBoxOlustur(int count, List<string> labelList)
        {
            for (int i = 1; i <= count; i++)
            {
                // Label oluşturuluyor
                Label label = new()
                {
                    Text = labelList[i - 1],
                    Location = new Point(20, this.topPosition),
                    AutoSize = true
                };

                // TextBox oluşturuluyor
                TextBox textBox = new()
                {
                    Location = new Point(100, this.topPosition),
                    Width = 200
                };
                textBoxList.Add(textBox); // TextBox'ı listeye ekle

                // Yeni Label ve TextBox'ı forma ekle
                this.Controls.Add(label);
                this.Controls.Add(textBox);

                // Sonraki öğeler için pozisyonu güncelle
                this.topPosition += 40; // Yükseklik aralığı
            }
        }

        private void BaslikVeRadioButtonOlustur(int count, List<string> labelList)
        {
            for(int i = 1; i <= count; i++)
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

        private void BaslikVeComboBoxOlustur(int count, List<string> labelList)
        {
            for (int i = 1; i <= count; i++)
            {
                // Label oluşturuluyor
                Label label = new()
                {
                    Text = labelList[i - 1],
                    Location = new Point(20, this.topPosition),
                    AutoSize = true
                };

                // ComboBox oluşturuluyor
                ComboBox comboBox = new()
                {
                    Location = new Point(100, this.topPosition),
                    Width = 200,
                    DropDownStyle = ComboBoxStyle.DropDownList // Sadece seçim yapılabilir hale getiriyoruz
                };

                if (i == 1)
                {
                    HayvanSahipleriniYukle(comboBox);
                }
                else if (i == 2)
                {
                    KlinikleriYukle(comboBox);
                }
                comboBoxList.Add(comboBox);
                
                this.Controls.Add(label);
                this.Controls.Add(comboBox);

                this.topPosition += 40; // TextBox'ların altında olacak şekilde pozisyonu güncelle
            }
        }

        private static void HayvanSahipleriniYukle(ComboBox comboBox)
        {
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";
            string query = "SELECT SahipId, CONCAT(Isim, ' ', Soyisim, ' - ', Telefon) AS Sahip FROM Sahipler";

            using SqlConnection connection = new SqlConnection(connectionString);
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

        // Klinik bilgilerini ComboBox'a yüklerken ValueMember ve DisplayMember kullanımı
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

        private void ButonlariOlustur()
        {
            // Tamam butonu
            Button btnOk = new()
            {
                Text = "Tamam",
                Location = new Point(100, this.topPosition), // Button'ı alt kısma yerleştiriyoruz
                Width = 100,
                Height = 35
            };
            btnOk.Click += BtnOk_Click; // Tamam butonuna tıklandığında çalışacak fonksiyon

            // İptal butonu
            Button btnCancel = new()
            {
                Text = "İptal",
                Location = new Point(200, this.topPosition), // Button'ı alt kısma yerleştiriyoruz
                Width = 100,
                Height = 35
            };
            btnCancel.Click += BtnCancel_Click; // İptal butonuna tıklandığında çalışacak fonksiyon

            // Butonları forma ekle
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            // Verileri al ve ekle
            Ekle(dataS);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ekle(int dataSource)
        {
            switch (dataSource)
            {
                case 1:
                    HayvanSahibiEkle();
                    break;
                case 2:
                    HayvanEkle();
                    break;
                case 3:
                    KlinikEkle();
                    break;
                case 4:
                    break;
            }
        }

        private static bool TextBoxKontrol(List<TextBox> boxlar)
        {
            for(int i = 0; i < boxlar.Count; i++)
            {
                if (string.IsNullOrEmpty(boxlar[i].Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void HayvanSahibiEkle()
        {
            bool dolu = TextBoxKontrol(textBoxList);

            if(dolu == false)
            {
                MessageBox.Show("Lutfen Boş Alanları Doldurunuz");
                return;
            }
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                string query = "INSERT INTO Sahipler (Isim, Soyisim, Telefon, Adres) VALUES (@Isim, @Soyisim, @Telefon, @Adres)";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                    command.Parameters.AddWithValue("@Soyisim", textBoxList[1].Text);
                    command.Parameters.AddWithValue("@Telefon", textBoxList[2].Text);
                    command.Parameters.AddWithValue("@Adres", textBoxList[3].Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Hayvan sahibi başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void HayvanEkle()
        {
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                string query = @"INSERT INTO Hayvanlar (Isim, Tur, Cins, Yas, EvcilMi, SahipId, KlinikId)
                               VALUES (@Isim, @Tur, @Cins, @Yas, @Evcil, @SahipId, @KlinikId)";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                    command.Parameters.AddWithValue("@Tur", textBoxList[1].Text);
                    command.Parameters.AddWithValue("@Cins", textBoxList[2].Text);

                    if (int.TryParse(textBoxList[3].Text, out int yas))
                    {
                        command.Parameters.AddWithValue("@Yas", yas);
                    }
                    else
                    {
                        MessageBox.Show("Yaş alanına geçerli bir sayı giriniz.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Evcil", radioButtonList[0].Checked ? 1 : 0);
                    if (comboBoxList[0].SelectedValue == null || comboBoxList[1].SelectedValue == null)
                    {
                        MessageBox.Show("Lütfen tüm seçimleri yapınız.");
                        return;
                    }
                    if (int.TryParse(comboBoxList[0].SelectedValue.ToString(), out int sahipId))
                    {
                        command.Parameters.AddWithValue("@SahipId", sahipId);
                    }
                    else
                    {
                        MessageBox.Show("Sahip seçimi geçersiz.");
                        return;
                    }

                    if (int.TryParse(comboBoxList[1].SelectedValue.ToString(), out int klinikId))
                    {
                        command.Parameters.AddWithValue("@KlinikId", klinikId);
                    }
                    else
                    {
                        MessageBox.Show("Klinik seçimi geçersiz.");
                        return;
                    }
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Hayvan başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void KlinikEkle()
        {
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                string query = "INSERT INTO Klinikler (Isim, Adres, Telefon) VALUES (@Isim, @Adres,  @Telefon)";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                    command.Parameters.AddWithValue("@Adres", textBoxList[1].Text);
                    command.Parameters.AddWithValue("@Telefon", textBoxList[2].Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Klinik başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
