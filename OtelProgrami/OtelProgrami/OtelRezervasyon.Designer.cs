namespace OtelProgrami
{
    partial class OtelRezervasyon
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
            this.dateTimePicker_Giris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Cikis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rezervasyonSorgula = new System.Windows.Forms.Button();
            this.comboBox_OdaTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_rezKayitlari = new System.Windows.Forms.Button();
            this.comboBox_odaOzellik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Sehir = new System.Windows.Forms.ComboBox();
            this.uygunOdalar_dataGrid = new System.Windows.Forms.DataGridView();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtelIsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaOzelligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uygunOdalar_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Giris
            // 
            this.dateTimePicker_Giris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Location = new System.Drawing.Point(749, 25);
            this.dateTimePicker_Giris.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Giris.Name = "dateTimePicker_Giris";
            this.dateTimePicker_Giris.Size = new System.Drawing.Size(323, 24);
            this.dateTimePicker_Giris.TabIndex = 0;
            // 
            // dateTimePicker_Cikis
            // 
            this.dateTimePicker_Cikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Location = new System.Drawing.Point(749, 77);
            this.dateTimePicker_Cikis.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Cikis.Name = "dateTimePicker_Cikis";
            this.dateTimePicker_Cikis.Size = new System.Drawing.Size(323, 24);
            this.dateTimePicker_Cikis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(648, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(646, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // rezervasyonSorgula
            // 
            this.rezervasyonSorgula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rezervasyonSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonSorgula.Location = new System.Drawing.Point(503, 196);
            this.rezervasyonSorgula.Margin = new System.Windows.Forms.Padding(5);
            this.rezervasyonSorgula.Name = "rezervasyonSorgula";
            this.rezervasyonSorgula.Size = new System.Drawing.Size(221, 74);
            this.rezervasyonSorgula.TabIndex = 4;
            this.rezervasyonSorgula.Text = "Rezervasyon Bul";
            this.rezervasyonSorgula.UseVisualStyleBackColor = false;
            this.rezervasyonSorgula.Click += new System.EventHandler(this.rezervasyonSorgula_Click);
            // 
            // comboBox_OdaTuru
            // 
            this.comboBox_OdaTuru.FormattingEnabled = true;
            this.comboBox_OdaTuru.Items.AddRange(new object[] {
            "Tek Kişilik Oda",
            "İki Kişilik Oda",
            "İkiz Yataklı Çift Kişilik Oda",
            "Üç Kişilik Oda"});
            this.comboBox_OdaTuru.Location = new System.Drawing.Point(166, 64);
            this.comboBox_OdaTuru.Name = "comboBox_OdaTuru";
            this.comboBox_OdaTuru.Size = new System.Drawing.Size(209, 33);
            this.comboBox_OdaTuru.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oda Türü:";
            // 
            // button_rezKayitlari
            // 
            this.button_rezKayitlari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_rezKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezKayitlari.Location = new System.Drawing.Point(991, 196);
            this.button_rezKayitlari.Margin = new System.Windows.Forms.Padding(5);
            this.button_rezKayitlari.Name = "button_rezKayitlari";
            this.button_rezKayitlari.Size = new System.Drawing.Size(214, 74);
            this.button_rezKayitlari.TabIndex = 14;
            this.button_rezKayitlari.Text = "Rezervasyon Kayıtları";
            this.button_rezKayitlari.UseVisualStyleBackColor = false;
            this.button_rezKayitlari.Click += new System.EventHandler(this.button_rezKayitlari_Click);
            // 
            // comboBox_odaOzellik
            // 
            this.comboBox_odaOzellik.FormattingEnabled = true;
            this.comboBox_odaOzellik.Items.AddRange(new object[] {
            "Ekonomik",
            "Dağ Manzarası",
            "Deniz Manzarası"});
            this.comboBox_odaOzellik.Location = new System.Drawing.Point(166, 114);
            this.comboBox_odaOzellik.Name = "comboBox_odaOzellik";
            this.comboBox_odaOzellik.Size = new System.Drawing.Size(209, 33);
            this.comboBox_odaOzellik.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Oda Özelliği:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(22, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Şehir:";
            // 
            // comboBox_Sehir
            // 
            this.comboBox_Sehir.FormattingEnabled = true;
            this.comboBox_Sehir.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Mersin",
            "Muğla",
            "Antalya"});
            this.comboBox_Sehir.Location = new System.Drawing.Point(165, 167);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(209, 33);
            this.comboBox_Sehir.TabIndex = 23;
            // 
            // uygunOdalar_dataGrid
            // 
            this.uygunOdalar_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uygunOdalar_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sehir,
            this.OtelIsim,
            this.OdaTuru,
            this.OdaOzelligi,
            this.OdaFiyati,
            this.GirisTarihi,
            this.CikisTarihi});
            this.uygunOdalar_dataGrid.Location = new System.Drawing.Point(12, 289);
            this.uygunOdalar_dataGrid.Name = "uygunOdalar_dataGrid";
            this.uygunOdalar_dataGrid.ShowCellToolTips = false;
            this.uygunOdalar_dataGrid.Size = new System.Drawing.Size(1197, 241);
            this.uygunOdalar_dataGrid.TabIndex = 24;
            this.uygunOdalar_dataGrid.TabStop = false;
            this.uygunOdalar_dataGrid.SelectionChanged += new System.EventHandler(this.uygunOdalar_dataGrid_SelectionChanged);
            // 
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            this.Sehir.Width = 150;
            // 
            // OtelIsim
            // 
            this.OtelIsim.HeaderText = "Otel İsmi";
            this.OtelIsim.Name = "OtelIsim";
            this.OtelIsim.ReadOnly = true;
            this.OtelIsim.Width = 235;
            // 
            // OdaTuru
            // 
            this.OdaTuru.HeaderText = "Oda Türü";
            this.OdaTuru.Name = "OdaTuru";
            this.OdaTuru.ReadOnly = true;
            this.OdaTuru.Width = 150;
            // 
            // OdaOzelligi
            // 
            this.OdaOzelligi.HeaderText = "Oda Özelliği";
            this.OdaOzelligi.Name = "OdaOzelligi";
            this.OdaOzelligi.ReadOnly = true;
            this.OdaOzelligi.Width = 150;
            // 
            // OdaFiyati
            // 
            this.OdaFiyati.HeaderText = "Oda Fiyatı";
            this.OdaFiyati.Name = "OdaFiyati";
            this.OdaFiyati.ReadOnly = true;
            this.OdaFiyati.Width = 150;
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.HeaderText = "Giriş Tarihi";
            this.GirisTarihi.Name = "GirisTarihi";
            this.GirisTarihi.ReadOnly = true;
            this.GirisTarihi.Width = 150;
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.HeaderText = "Çıkış Tarihi";
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.ReadOnly = true;
            this.CikisTarihi.Width = 150;
            // 
            // rezTamamla
            // 
            this.rezTamamla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rezTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezTamamla.Location = new System.Drawing.Point(749, 196);
            this.rezTamamla.Margin = new System.Windows.Forms.Padding(5);
            this.rezTamamla.Name = "rezTamamla";
            this.rezTamamla.Size = new System.Drawing.Size(221, 74);
            this.rezTamamla.TabIndex = 25;
            this.rezTamamla.Text = "Rezervasyonu Tamamla";
            this.rezTamamla.UseVisualStyleBackColor = false;
            this.rezTamamla.Click += new System.EventHandler(this.rezTamamla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(662, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Listelenen odalardan birini seçip, Rezervasyon Tamamla\'ya basınız.";
            // 
            // OtelRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rezTamamla);
            this.Controls.Add(this.uygunOdalar_dataGrid);
            this.Controls.Add(this.comboBox_Sehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_odaOzellik);
            this.Controls.Add(this.button_rezKayitlari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_OdaTuru);
            this.Controls.Add(this.rezervasyonSorgula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Cikis);
            this.Controls.Add(this.dateTimePicker_Giris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "OtelRezervasyon";
            this.Text = "OtelRezervasyon";
            this.Load += new System.EventHandler(this.OtelRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uygunOdalar_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Giris;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rezervasyonSorgula;
        private System.Windows.Forms.ComboBox comboBox_OdaTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rezKayitlari;
        private System.Windows.Forms.ComboBox comboBox_odaOzellik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Sehir;
        private System.Windows.Forms.DataGridView uygunOdalar_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtelIsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaOzelligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarihi;
        private System.Windows.Forms.Button rezTamamla;
        private System.Windows.Forms.Label label3;
    }
}