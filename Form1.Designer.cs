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
            hsList = new HayvanSahipleriListe();
            hList = new HayvanlariListele();
            kList = new KlinikListele();
            mList = new MuayeneListele();
            panel1.SuspendLayout();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 450);
            panel1.TabIndex = 0;
            // 
            // MuayeneleriListeleBtn
            // 
            MuayeneleriListeleBtn.BackColor = Color.FromArgb(238, 238, 238);
            MuayeneleriListeleBtn.Dock = DockStyle.Top;
            MuayeneleriListeleBtn.FlatStyle = FlatStyle.Flat;
            MuayeneleriListeleBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuayeneleriListeleBtn.ForeColor = Color.Black;
            MuayeneleriListeleBtn.Location = new Point(0, 168);
            MuayeneleriListeleBtn.Margin = new Padding(0);
            MuayeneleriListeleBtn.Name = "MuayeneleriListeleBtn";
            MuayeneleriListeleBtn.Size = new Size(160, 56);
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
            KlinikListeleBtn.Location = new Point(0, 112);
            KlinikListeleBtn.Margin = new Padding(0);
            KlinikListeleBtn.Name = "KlinikListeleBtn";
            KlinikListeleBtn.Size = new Size(160, 56);
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
            HayvanListeleBtn.Location = new Point(0, 56);
            HayvanListeleBtn.Margin = new Padding(0);
            HayvanListeleBtn.Name = "HayvanListeleBtn";
            HayvanListeleBtn.Size = new Size(160, 56);
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
            sahipListeleBtn.Size = new Size(160, 56);
            sahipListeleBtn.TabIndex = 0;
            sahipListeleBtn.Text = "Hayvan Sahiplerini Listele";
            sahipListeleBtn.UseVisualStyleBackColor = false;
            sahipListeleBtn.Click += SahipListeleBtn_Click;
            // 
            // hsList
            // 
            hsList.AutoSize = true;
            hsList.BackColor = Color.FromArgb(34, 40, 49);
            hsList.Dock = DockStyle.Fill;
            hsList.Location = new Point(160, 0);
            hsList.Margin = new Padding(3, 2, 3, 2);
            hsList.Name = "hsList";
            hsList.Size = new Size(916, 450);
            hsList.TabIndex = 1;
            hsList.Visible = false;
            // 
            // hList
            // 
            hList.AutoSize = true;
            hList.BackColor = Color.FromArgb(34, 40, 49);
            hList.Dock = DockStyle.Fill;
            hList.Location = new Point(160, 0);
            hList.Name = "hList";
            hList.Size = new Size(916, 450);
            hList.TabIndex = 2;
            hList.Visible = false;
            // 
            // kList
            // 
            kList.AutoSize = true;
            kList.BackColor = Color.FromArgb(34, 40, 49);
            kList.Dock = DockStyle.Fill;
            kList.Location = new Point(160, 0);
            kList.Name = "kList";
            kList.Size = new Size(916, 450);
            kList.TabIndex = 4;
            kList.Visible = false;
            // 
            // mList
            // 
            mList.BackColor = Color.FromArgb(34, 40, 49);
            mList.Dock = DockStyle.Fill;
            mList.Location = new Point(160, 0);
            mList.Name = "mList";
            mList.Size = new Size(916, 450);
            mList.TabIndex = 5;
            mList.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1076, 450);
            Controls.Add(mList);
            Controls.Add(hsList);
            Controls.Add(hList);
            Controls.Add(kList);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1092, 489);
            Name = "Form1";
            Text = "Veteriner Klinik Yönetim Sistemi";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button sahipListeleBtn;
        private HayvanSahipleriListe hsList;
        private Button HayvanListeleBtn;
        private HayvanlariListele hList;
        private Button MuayeneleriListeleBtn;
        private Button KlinikListeleBtn;
        private KlinikListele kList;
        private MuayeneListele mList;
    }
}
