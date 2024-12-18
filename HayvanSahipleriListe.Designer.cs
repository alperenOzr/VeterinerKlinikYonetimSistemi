namespace VeterinerKlinikYonetimSistemi
{
    partial class HayvanSahipleriListe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            sahipIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyisimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kayitTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sahiplerBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sahiplerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sahipIDDataGridViewTextBoxColumn, ısimDataGridViewTextBoxColumn, soyisimDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, kayitTarihiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sahiplerBindingSource;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(919, 386);
            dataGridView1.TabIndex = 0;
            // 
            // sahipIDDataGridViewTextBoxColumn
            // 
            sahipIDDataGridViewTextBoxColumn.DataPropertyName = "SahipID";
            sahipIDDataGridViewTextBoxColumn.HeaderText = "SahipID";
            sahipIDDataGridViewTextBoxColumn.Name = "sahipIDDataGridViewTextBoxColumn";
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            // 
            // sahiplerBindingSource
            // 
            sahiplerBindingSource.DataSource = typeof(Sahipler);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İsme göre sırala", "İsme göre tersten sırala", "Soyisme göre sırala", "Soyisme göre tersten sırala", "Telefona göre sırala", "Telefona göre tersten sırala", "Tarihe göre sırala", "Tarihe göre tersten sırala" });
            comboBox1.Location = new Point(53, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // HayvanSahipleriListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HayvanSahipleriListe";
            Size = new Size(919, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sahiplerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn sahipIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private BindingSource sahiplerBindingSource;
        public DataGridView dataGridView1;
        public ComboBox comboBox1;
    }
}
