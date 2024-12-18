namespace VeterinerKlinikYonetimSistemi
{
    partial class MuayeneListele
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
            muayeneBindingSource = new BindingSource(components);
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hayvanIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            klinikIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yapilanIslemlerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notlarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)muayeneBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, hayvanIdDataGridViewTextBoxColumn, klinikIdDataGridViewTextBoxColumn, tarihDataGridViewTextBoxColumn, yapilanIslemlerDataGridViewTextBoxColumn, notlarDataGridViewTextBoxColumn });
            dataGridView1.DataSource = muayeneBindingSource;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(919, 386);
            dataGridView1.TabIndex = 2;
            // 
            // muayeneBindingSource
            // 
            muayeneBindingSource.DataSource = typeof(Muayene);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // hayvanIdDataGridViewTextBoxColumn
            // 
            hayvanIdDataGridViewTextBoxColumn.DataPropertyName = "HayvanId";
            hayvanIdDataGridViewTextBoxColumn.HeaderText = "HayvanId";
            hayvanIdDataGridViewTextBoxColumn.Name = "hayvanIdDataGridViewTextBoxColumn";
            // 
            // klinikIdDataGridViewTextBoxColumn
            // 
            klinikIdDataGridViewTextBoxColumn.DataPropertyName = "KlinikId";
            klinikIdDataGridViewTextBoxColumn.HeaderText = "KlinikId";
            klinikIdDataGridViewTextBoxColumn.Name = "klinikIdDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // yapilanIslemlerDataGridViewTextBoxColumn
            // 
            yapilanIslemlerDataGridViewTextBoxColumn.DataPropertyName = "YapilanIslemler";
            yapilanIslemlerDataGridViewTextBoxColumn.HeaderText = "YapilanIslemler";
            yapilanIslemlerDataGridViewTextBoxColumn.Name = "yapilanIslemlerDataGridViewTextBoxColumn";
            // 
            // notlarDataGridViewTextBoxColumn
            // 
            notlarDataGridViewTextBoxColumn.DataPropertyName = "Notlar";
            notlarDataGridViewTextBoxColumn.HeaderText = "Notlar";
            notlarDataGridViewTextBoxColumn.Name = "notlarDataGridViewTextBoxColumn";
            // 
            // MuayeneListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(dataGridView1);
            Name = "MuayeneListele";
            Size = new Size(919, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)muayeneBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hayvanIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn klinikIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yapilanIslemlerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notlarDataGridViewTextBoxColumn;
        private BindingSource muayeneBindingSource;
    }
}
