namespace VeterinerKlinikYonetimSistemi
{
    partial class HayvanlariListele
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
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            evcilMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            sahipIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            klinikIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hayvanlarBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hayvanlarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, ısimDataGridViewTextBoxColumn, turDataGridViewTextBoxColumn, cinsDataGridViewTextBoxColumn, yasDataGridViewTextBoxColumn, evcilMiDataGridViewCheckBoxColumn, sahipIDDataGridViewTextBoxColumn, klinikIDDataGridViewTextBoxColumn });
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(919, 386);
            dataGridView1.TabIndex = 1;
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
            // turDataGridViewTextBoxColumn
            // 
            turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            turDataGridViewTextBoxColumn.HeaderText = "Tur";
            turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // cinsDataGridViewTextBoxColumn
            // 
            cinsDataGridViewTextBoxColumn.DataPropertyName = "Cins";
            cinsDataGridViewTextBoxColumn.HeaderText = "Cins";
            cinsDataGridViewTextBoxColumn.Name = "cinsDataGridViewTextBoxColumn";
            // 
            // yasDataGridViewTextBoxColumn
            // 
            yasDataGridViewTextBoxColumn.DataPropertyName = "Yas";
            yasDataGridViewTextBoxColumn.HeaderText = "Yas";
            yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            // 
            // evcilMiDataGridViewCheckBoxColumn
            // 
            evcilMiDataGridViewCheckBoxColumn.DataPropertyName = "EvcilMi";
            evcilMiDataGridViewCheckBoxColumn.HeaderText = "EvcilMi";
            evcilMiDataGridViewCheckBoxColumn.Name = "evcilMiDataGridViewCheckBoxColumn";
            // 
            // sahipIDDataGridViewTextBoxColumn
            // 
            sahipIDDataGridViewTextBoxColumn.DataPropertyName = "SahipID";
            sahipIDDataGridViewTextBoxColumn.HeaderText = "SahipID";
            sahipIDDataGridViewTextBoxColumn.Name = "sahipIDDataGridViewTextBoxColumn";
            // 
            // klinikIDDataGridViewTextBoxColumn
            // 
            klinikIDDataGridViewTextBoxColumn.DataPropertyName = "KlinikID";
            klinikIDDataGridViewTextBoxColumn.HeaderText = "KlinikID";
            klinikIDDataGridViewTextBoxColumn.Name = "klinikIDDataGridViewTextBoxColumn";
            // 
            // hayvanlarBindingSource
            // 
            hayvanlarBindingSource.DataSource = typeof(Hayvanlar);
            // 
            // HayvanlariListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(dataGridView1);
            Name = "HayvanlariListele";
            Size = new Size(919, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hayvanlarBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn evcilMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn sahipIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn klinikIDDataGridViewTextBoxColumn;
        private BindingSource hayvanlarBindingSource;
    }
}
