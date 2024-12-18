namespace VeterinerKlinikYonetimSistemi
{
    partial class KlinikListele
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
            klinikBindingSource = new BindingSource(components);
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bakilanHayvanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klinikBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, ısimDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, bakilanHayvanDataGridViewTextBoxColumn });
            dataGridView1.DataSource = klinikBindingSource;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(919, 386);
            dataGridView1.TabIndex = 1;
            // 
            // klinikBindingSource
            // 
            klinikBindingSource.DataSource = typeof(Klinik);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // bakilanHayvanDataGridViewTextBoxColumn
            // 
            bakilanHayvanDataGridViewTextBoxColumn.DataPropertyName = "BakilanHayvan";
            bakilanHayvanDataGridViewTextBoxColumn.HeaderText = "BakilanHayvan";
            bakilanHayvanDataGridViewTextBoxColumn.Name = "bakilanHayvanDataGridViewTextBoxColumn";
            // 
            // KlinikListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(dataGridView1);
            Name = "KlinikListele";
            Size = new Size(919, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)klinikBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bakilanHayvanDataGridViewTextBoxColumn;
        private BindingSource klinikBindingSource;
        private BindingSource klinikBindingSource1;
        private DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
    }
}
