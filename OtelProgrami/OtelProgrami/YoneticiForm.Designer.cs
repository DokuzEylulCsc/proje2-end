namespace OtelProgrami
{
    partial class YoneticiForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_rezSorgu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaOzelligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtelTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervasyonListesi = new System.Windows.Forms.DataGridView();
            this.iterasyonSorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Ekle
            // 
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ekle.Location = new System.Drawing.Point(145, 317);
            this.button_Ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(115, 44);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Otel Ve Oda İşlemleri";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_rezSorgu
            // 
            this.button_rezSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezSorgu.Location = new System.Drawing.Point(610, 317);
            this.button_rezSorgu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rezSorgu.Name = "button_rezSorgu";
            this.button_rezSorgu.Size = new System.Drawing.Size(115, 44);
            this.button_rezSorgu.TabIndex = 11;
            this.button_rezSorgu.Text = "Rezervasyon Sorgula";
            this.button_rezSorgu.UseVisualStyleBackColor = true;
            this.button_rezSorgu.Click += new System.EventHandler(this.button_rezSorgu_Click);
            // 
            // CikisTarihi
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CikisTarihi.DefaultCellStyle = dataGridViewCellStyle1;
            this.CikisTarihi.HeaderText = "Çıkış Tarihi";
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Width = 120;
            // 
            // GirisTarih
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GirisTarih.DefaultCellStyle = dataGridViewCellStyle2;
            this.GirisTarih.HeaderText = "Giriş Tarihi";
            this.GirisTarih.Name = "GirisTarih";
            this.GirisTarih.Width = 120;
            // 
            // Ucret
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ucret.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ucret.HeaderText = "Ücret";
            this.Ucret.Name = "Ucret";
            // 
            // OdaTuru
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OdaTuru.DefaultCellStyle = dataGridViewCellStyle4;
            this.OdaTuru.HeaderText = "Oda Türü";
            this.OdaTuru.Name = "OdaTuru";
            // 
            // OdaOzelligi
            // 
            this.OdaOzelligi.HeaderText = "Oda Özelliği";
            this.OdaOzelligi.Name = "OdaOzelligi";
            this.OdaOzelligi.Width = 120;
            // 
            // OtelTuru
            // 
            this.OtelTuru.HeaderText = "Otel Türü";
            this.OtelTuru.Name = "OtelTuru";
            // 
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            // 
            // TC
            // 
            this.TC.HeaderText = "TC";
            this.TC.Name = "TC";
            // 
            // Soyad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Soyad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // Ad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.Ad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // RezervasyonListesi
            // 
            this.RezervasyonListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyonListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.TC,
            this.Sehir,
            this.OtelTuru,
            this.OdaOzelligi,
            this.OdaTuru,
            this.Ucret,
            this.GirisTarih,
            this.CikisTarihi});
            this.RezervasyonListesi.Location = new System.Drawing.Point(9, 9);
            this.RezervasyonListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RezervasyonListesi.Name = "RezervasyonListesi";
            this.RezervasyonListesi.RowTemplate.Height = 24;
            this.RezervasyonListesi.Size = new System.Drawing.Size(838, 236);
            this.RezervasyonListesi.TabIndex = 17;
            // 
            // iterasyonSorgula
            // 
            this.iterasyonSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iterasyonSorgula.Location = new System.Drawing.Point(359, 317);
            this.iterasyonSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.iterasyonSorgula.Name = "iterasyonSorgula";
            this.iterasyonSorgula.Size = new System.Drawing.Size(115, 44);
            this.iterasyonSorgula.TabIndex = 18;
            this.iterasyonSorgula.Text = "İterasyon Sorgula";
            this.iterasyonSorgula.UseVisualStyleBackColor = true;
            this.iterasyonSorgula.Click += new System.EventHandler(this.iterasyonSorgula_Click);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 424);
            this.Controls.Add(this.iterasyonSorgula);
            this.Controls.Add(this.RezervasyonListesi);
            this.Controls.Add(this.button_rezSorgu);
            this.Controls.Add(this.button_Ekle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "YoneticiForm";
            this.Text = "YöneticiForm";
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_rezSorgu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaOzelligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtelTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridView RezervasyonListesi;
        private System.Windows.Forms.Button iterasyonSorgula;
    }
}