namespace VeterinerKlinikYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            MuayeneleriListeleBtn = new Button();
            KlinikListeleBtn = new Button();
            HayvanListeleBtn = new Button();
            sahipListeleBtn = new Button();
            dataGridPnl = new Panel();
            dataGridView1 = new DataGridView();
            klinikPnl = new Panel();
            EkleBtn = new Button();
            SilBtn = new Button();
            panel1.SuspendLayout();
            dataGridPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            klinikPnl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(MuayeneleriListeleBtn);
            panel1.Controls.Add(KlinikListeleBtn);
            panel1.Controls.Add(HayvanListeleBtn);
            panel1.Controls.Add(sahipListeleBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 600);
            panel1.TabIndex = 0;
            // 
            // MuayeneleriListeleBtn
            // 
            MuayeneleriListeleBtn.BackColor = Color.FromArgb(238, 238, 238);
            MuayeneleriListeleBtn.Dock = DockStyle.Top;
            MuayeneleriListeleBtn.FlatStyle = FlatStyle.Flat;
            MuayeneleriListeleBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuayeneleriListeleBtn.ForeColor = Color.Black;
            MuayeneleriListeleBtn.Location = new Point(0, 225);
            MuayeneleriListeleBtn.Margin = new Padding(0);
            MuayeneleriListeleBtn.Name = "MuayeneleriListeleBtn";
            MuayeneleriListeleBtn.Size = new Size(183, 75);
            MuayeneleriListeleBtn.TabIndex = 3;
            MuayeneleriListeleBtn.Text = "Muayeneleri Listele";
            MuayeneleriListeleBtn.UseVisualStyleBackColor = false;
            MuayeneleriListeleBtn.Click += MuayeneleriListeleBtn_Click;
            // 
            // KlinikListeleBtn
            // 
            KlinikListeleBtn.BackColor = Color.FromArgb(238, 238, 238);
            KlinikListeleBtn.Dock = DockStyle.Top;
            KlinikListeleBtn.FlatStyle = FlatStyle.Flat;
            KlinikListeleBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KlinikListeleBtn.ForeColor = Color.Black;
            KlinikListeleBtn.Location = new Point(0, 150);
            KlinikListeleBtn.Margin = new Padding(0);
            KlinikListeleBtn.Name = "KlinikListeleBtn";
            KlinikListeleBtn.Size = new Size(183, 75);
            KlinikListeleBtn.TabIndex = 2;
            KlinikListeleBtn.Text = "Klinikleri Listele";
            KlinikListeleBtn.UseVisualStyleBackColor = false;
            KlinikListeleBtn.Click += KlinikListeleBtn_Click;
            // 
            // HayvanListeleBtn
            // 
            HayvanListeleBtn.BackColor = Color.FromArgb(238, 238, 238);
            HayvanListeleBtn.Dock = DockStyle.Top;
            HayvanListeleBtn.FlatStyle = FlatStyle.Flat;
            HayvanListeleBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HayvanListeleBtn.ForeColor = Color.Black;
            HayvanListeleBtn.Location = new Point(0, 75);
            HayvanListeleBtn.Margin = new Padding(0);
            HayvanListeleBtn.Name = "HayvanListeleBtn";
            HayvanListeleBtn.Size = new Size(183, 75);
            HayvanListeleBtn.TabIndex = 1;
            HayvanListeleBtn.Text = "Hayvanları Listele";
            HayvanListeleBtn.UseVisualStyleBackColor = false;
            HayvanListeleBtn.Click += HayvanListeleBtn_Click;
            // 
            // sahipListeleBtn
            // 
            sahipListeleBtn.BackColor = Color.FromArgb(238, 238, 238);
            sahipListeleBtn.Dock = DockStyle.Top;
            sahipListeleBtn.FlatStyle = FlatStyle.Flat;
            sahipListeleBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sahipListeleBtn.ForeColor = Color.Black;
            sahipListeleBtn.Location = new Point(0, 0);
            sahipListeleBtn.Margin = new Padding(0);
            sahipListeleBtn.Name = "sahipListeleBtn";
            sahipListeleBtn.Size = new Size(183, 75);
            sahipListeleBtn.TabIndex = 0;
            sahipListeleBtn.Text = "Hayvan Sahiplerini Listele";
            sahipListeleBtn.UseVisualStyleBackColor = false;
            sahipListeleBtn.Click += SahipListeleBtn_Click;
            // 
            // dataGridPnl
            // 
            dataGridPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPnl.Controls.Add(dataGridView1);
            dataGridPnl.Location = new Point(183, 150);
            dataGridPnl.Name = "dataGridPnl";
            dataGridPnl.Size = new Size(1047, 450);
            dataGridPnl.TabIndex = 6;
            dataGridPnl.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1047, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // klinikPnl
            // 
            klinikPnl.Controls.Add(EkleBtn);
            klinikPnl.Controls.Add(SilBtn);
            klinikPnl.Dock = DockStyle.Top;
            klinikPnl.Location = new Point(183, 0);
            klinikPnl.Name = "klinikPnl";
            klinikPnl.Size = new Size(1047, 150);
            klinikPnl.TabIndex = 7;
            // 
            // EkleBtn
            // 
            EkleBtn.Location = new Point(184, 46);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(94, 29);
            EkleBtn.TabIndex = 1;
            EkleBtn.Text = "Ekle";
            EkleBtn.UseVisualStyleBackColor = true;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // SilBtn
            // 
            SilBtn.Location = new Point(57, 46);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(94, 29);
            SilBtn.TabIndex = 0;
            SilBtn.Text = "Sil";
            SilBtn.UseVisualStyleBackColor = true;
            SilBtn.Click += SilBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1230, 600);
            Controls.Add(klinikPnl);
            Controls.Add(dataGridPnl);
            Controls.Add(panel1);
            MinimumSize = new Size(1245, 636);
            Name = "Form1";
            Text = "Veteriner Klinik Yönetim Sistemi";
            panel1.ResumeLayout(false);
            dataGridPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            klinikPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button sahipListeleBtn;
        private Button HayvanListeleBtn;
        private Button MuayeneleriListeleBtn;
        private Button KlinikListeleBtn;
        private Panel dataGridPnl;
        private DataGridView dataGridView1;
        private Panel klinikPnl;
        private Button YenileBtn;
        private Button button1;
        private Button SilBtn;
        private Button EkleBtn;
    }
}
