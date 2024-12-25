using Microsoft.Data.SqlClient;

namespace VeterinerKlinikYonetimSistemi
{
    public partial class MessageBoxForm : Form
    {
        private int dataS = 0;
        private List<TextBox> textBoxList = []; // TextBox'ları saklamak için liste
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
                    [   "İsim",
                        "Soyisim",
                        "Telefon",
                        "Adres"
                    ]);
                    break;
                //Hayvanlar için
                case 2:
                    this.Text = "Hayvan Ekle";
                    BaslikVeTextBoxOlustur(5,
                    [   "İsim",
                        "Tur",
                        "Cins",
                        "Yas",
                        "Evcil",
                    ]);
                    BaslikVeComboBoxOlustur(2,
                    [   "Sahibi",
                        "Klinik"
                    ]);

                    break;
                //Klinikler için
                case 3:
                    this.Text = "Klinik Ekle";
                    List<string> labelList2 =
                    [
                        "İsim",
                        "Adres",
                        "Telefon"
                    ];
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
                Label label = new Label
                {
                    Text = labelList[i - 1],
                    Location = new Point(20, this.topPosition),
                    AutoSize = true
                };

                // TextBox oluşturuluyor
                TextBox textBox = new TextBox
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
                    Width = 200
                };

                // Eğer bu ilk ComboBox ise, sahip bilgilerini veritabanından çek
                if (i == 1)
                {
                    // Veritabanından sahipleri çekme fonksiyonunu çağırıyoruz
                    HayvanSahipleriniYukle(comboBox);
                }
                else if (i == 2)
                {
                    KlinikleriYukle(comboBox);
                }

                // Yeni Label ve ComboBox'ı forma ekle
                this.Controls.Add(label);
                this.Controls.Add(comboBox);

                // Sonraki öğeler için pozisyonu güncelle
                this.topPosition += 40; // TextBox'ların altında olacak şekilde pozisyonu güncelle

                static void HayvanSahipleriniYukle(ComboBox comboBox)
                {
                    // Veritabanı bağlantı dizesi (bu dizeyi kendi veritabanınıza göre güncellemelisiniz)
                    string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

                    // SQL sorgusu
                    string query = "SELECT CONCAT(Isim, ' ', Soyisim, ' - ', Telefon) AS Sahip FROM Sahipler";

                    // SqlConnection ve SqlCommand nesnelerini oluşturuyoruz
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // SqlCommand nesnesini oluşturuyoruz
                        SqlCommand command = new SqlCommand(query, connection);

                        try
                        {
                            // Veritabanına bağlanıyoruz
                            connection.Open();

                            // Sorguyu çalıştırıyoruz
                            SqlDataReader reader = command.ExecuteReader();

                            // Eğer veri varsa, ComboBox'a ekliyoruz
                            while (reader.Read())
                            {
                                // Sahip bilgilerini ComboBox'a ekliyoruz
                                comboBox.Items.Add(reader["Sahip"].ToString());
                            }

                            // Varsayılan olarak ilk öğeyi seçili yapıyoruz
                            if (comboBox.Items.Count > 0)
                            {
                                comboBox.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veritabanı hatası: " + ex.Message);
                        }
                    }
                }
                static void KlinikleriYukle(ComboBox comboBox)
                {
                    // Veritabanı bağlantı dizesi (bu dizeyi kendi veritabanınıza göre güncellemelisiniz)
                    string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

                    // SQL sorgusu - Benzersiz klinik isimlerini çekmek için DISTINCT kullanıyoruz
                    string query = "SELECT DISTINCT Isim FROM Klinikler";

                    // SqlConnection ve SqlCommand nesnelerini oluşturuyoruz
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // SqlCommand nesnesini oluşturuyoruz
                        SqlCommand command = new SqlCommand(query, connection);

                        try
                        {
                            // Veritabanına bağlanıyoruz
                            connection.Open();

                            // Sorguyu çalıştırıyoruz
                            SqlDataReader reader = command.ExecuteReader();

                            // Eğer veri varsa, ComboBox'a ekliyoruz
                            while (reader.Read())
                            {
                                // Klinik adını ComboBox'a ekliyoruz
                                comboBox.Items.Add(reader["Isim"].ToString());
                            }

                            // Varsayılan olarak ilk öğeyi seçili yapıyoruz
                            if (comboBox.Items.Count > 0)
                            {
                                comboBox.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veritabanı hatası: " + ex.Message);
                        }
                    }
                }
            }
        }

        // Tamam ve İptal butonlarını oluşturma fonksiyonu
        private void ButonlariOlustur()
        {
            // Tamam butonu
            Button btnOk = new Button
            {
                Text = "Tamam",
                Location = new Point(100, this.topPosition), // Button'ı alt kısma yerleştiriyoruz
                Width = 100,
                Height = 35
            };
            btnOk.Click += BtnOk_Click; // Tamam butonuna tıklandığında çalışacak fonksiyon

            // İptal butonu
            Button btnCancel = new Button
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

        // Tamam butonuna tıklandığında yapılacak işlem
        private void BtnOk_Click(object? sender, EventArgs e)
        {
            // Verileri al ve ekle
            Ekle(dataS);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // İptal butonuna tıklandığında yapılacak işlem
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            // İptal işleminden sonra formu kapat
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ekle(int dataSource)
        {
            switch (dataSource)
            {
                case 1:
                    // Sahipler tablosuna ekleme işlemi
                    HayvanSahibiEkle();
                    break;
                case 2:
                    break;
                case 3:
                    KlinikEkle();
                    break;
                case 4:
                    break;
            }
        }

        private void HayvanSahibiEkle()
        {
            // Veritabanı bağlantı dizesi
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL komut metni
                    string query = "INSERT INTO Sahipler (Isim, Soyisim, Telefon, Adres) VALUES (@Isim, @Soyisim, @Telefon, @Adres)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekleyelim
                        command.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                        command.Parameters.AddWithValue("@Soyisim", textBoxList[1].Text);
                        command.Parameters.AddWithValue("@Telefon", textBoxList[2].Text);
                        command.Parameters.AddWithValue("@Adres", textBoxList[3].Text);

                        // SQL komutunu çalıştırıyoruz
                        command.ExecuteNonQuery();
                    }

                    // Başarı mesajı
                    MessageBox.Show("Hayvan sahibi başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void KlinikEkle()
        {
            // Veritabanı bağlantı dizesi
            string connectionString = "Server=ALPEREN\\SQLEXPRESS;Database=KlinikYonetimSistemi;User ID=sa;Password=Alperen1; Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL komut metni
                    string query = "INSERT INTO Klinikler (Isim, Adres, Telefon) VALUES (@Isim, @Adres,  @Telefon)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekleyelim
                        command.Parameters.AddWithValue("@Isim", textBoxList[0].Text);
                        command.Parameters.AddWithValue("@Adres", textBoxList[1].Text);
                        command.Parameters.AddWithValue("@Telefon", textBoxList[2].Text);

                        // SQL komutunu çalıştırıyoruz
                        command.ExecuteNonQuery();
                    }

                    // Başarı mesajı
                    MessageBox.Show("Klinik başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
