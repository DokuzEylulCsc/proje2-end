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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_Giris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Cikis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_otelTuru = new System.Windows.Forms.ComboBox();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.comboBox_odaTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_rezSorgu = new System.Windows.Forms.Button();
            this.radioButton_ucYildiz = new System.Windows.Forms.RadioButton();
            this.radioButton_dortYildiz = new System.Windows.Forms.RadioButton();
            this.radioButton_besYildiz = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_odaOzelligi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtelTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaOzelligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Giris
            // 
            this.dateTimePicker_Giris.Location = new System.Drawing.Point(510, 51);
            this.dateTimePicker_Giris.Name = "dateTimePicker_Giris";
            this.dateTimePicker_Giris.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Giris.TabIndex = 0;
            // 
            // dateTimePicker_Cikis
            // 
            this.dateTimePicker_Cikis.Location = new System.Drawing.Point(510, 95);
            this.dateTimePicker_Cikis.Name = "dateTimePicker_Cikis";
            this.dateTimePicker_Cikis.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Cikis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(453, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giriş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(453, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çıkış:";
            // 
            // comboBox_otelTuru
            // 
            this.comboBox_otelTuru.FormattingEnabled = true;
            this.comboBox_otelTuru.Items.AddRange(new object[] {
            "Butik",
            "Pansiyon",
            "Tatil Köyü"});
            this.comboBox_otelTuru.Location = new System.Drawing.Point(134, 42);
            this.comboBox_otelTuru.Name = "comboBox_otelTuru";
            this.comboBox_otelTuru.Size = new System.Drawing.Size(168, 24);
            this.comboBox_otelTuru.TabIndex = 4;
            // 
            // button_Ekle
            // 
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ekle.Location = new System.Drawing.Point(852, 21);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(153, 54);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            // 
            // comboBox_odaTuru
            // 
            this.comboBox_odaTuru.FormattingEnabled = true;
            this.comboBox_odaTuru.Items.AddRange(new object[] {
            "Tek Kişik",
            "Çift Kişilik",
            "İkiz Yataklı Çift Kişilik",
            "Üç Kişilik"});
            this.comboBox_odaTuru.Location = new System.Drawing.Point(134, 97);
            this.comboBox_odaTuru.Name = "comboBox_odaTuru";
            this.comboBox_odaTuru.Size = new System.Drawing.Size(168, 24);
            this.comboBox_odaTuru.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Otel Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Oda Türü:";
            // 
            // button_Sil
            // 
            this.button_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sil.Location = new System.Drawing.Point(852, 89);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(153, 54);
            this.button_Sil.TabIndex = 10;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            // 
            // button_rezSorgu
            // 
            this.button_rezSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezSorgu.Location = new System.Drawing.Point(852, 159);
            this.button_rezSorgu.Name = "button_rezSorgu";
            this.button_rezSorgu.Size = new System.Drawing.Size(153, 54);
            this.button_rezSorgu.TabIndex = 11;
            this.button_rezSorgu.Text = "Rezervasyon Sorgula";
            this.button_rezSorgu.UseVisualStyleBackColor = true;
            // 
            // radioButton_ucYildiz
            // 
            this.radioButton_ucYildiz.AutoSize = true;
            this.radioButton_ucYildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_ucYildiz.Location = new System.Drawing.Point(369, 159);
            this.radioButton_ucYildiz.Name = "radioButton_ucYildiz";
            this.radioButton_ucYildiz.Size = new System.Drawing.Size(60, 29);
            this.radioButton_ucYildiz.TabIndex = 12;
            this.radioButton_ucYildiz.TabStop = true;
            this.radioButton_ucYildiz.Text = "***";
            this.radioButton_ucYildiz.UseVisualStyleBackColor = true;
            // 
            // radioButton_dortYildiz
            // 
            this.radioButton_dortYildiz.AutoSize = true;
            this.radioButton_dortYildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_dortYildiz.Location = new System.Drawing.Point(504, 159);
            this.radioButton_dortYildiz.Name = "radioButton_dortYildiz";
            this.radioButton_dortYildiz.Size = new System.Drawing.Size(69, 29);
            this.radioButton_dortYildiz.TabIndex = 13;
            this.radioButton_dortYildiz.TabStop = true;
            this.radioButton_dortYildiz.Text = "****";
            this.radioButton_dortYildiz.UseVisualStyleBackColor = true;
            // 
            // radioButton_besYildiz
            // 
            this.radioButton_besYildiz.AutoSize = true;
            this.radioButton_besYildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_besYildiz.Location = new System.Drawing.Point(645, 159);
            this.radioButton_besYildiz.Name = "radioButton_besYildiz";
            this.radioButton_besYildiz.Size = new System.Drawing.Size(78, 29);
            this.radioButton_besYildiz.TabIndex = 14;
            this.radioButton_besYildiz.TabStop = true;
            this.radioButton_besYildiz.Text = "*****";
            this.radioButton_besYildiz.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Oda Özelliği:";
            // 
            // comboBox_odaOzelligi
            // 
            this.comboBox_odaOzelligi.FormattingEnabled = true;
            this.comboBox_odaOzelligi.Items.AddRange(new object[] {
            "Ekonomik",
            "Normal",
            "Dağ Manzarası",
            "Deniz Manzarası"});
            this.comboBox_odaOzelligi.Location = new System.Drawing.Point(134, 138);
            this.comboBox_odaOzelligi.Name = "comboBox_odaOzelligi";
            this.comboBox_odaOzelligi.Size = new System.Drawing.Size(168, 24);
            this.comboBox_odaOzelligi.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.Tel,
            this.Email,
            this.OtelTuru,
            this.OdaOzelligi,
            this.OdaTuru,
            this.Ucret,
            this.GirisTarih,
            this.CikisTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(2, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // Ad
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Ad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Soyad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // Tel
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tel.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            // 
            // OtelTuru
            // 
            this.OtelTuru.HeaderText = "Otel Türü";
            this.OtelTuru.Name = "OtelTuru";
            // 
            // OdaOzelligi
            // 
            this.OdaOzelligi.HeaderText = "Oda Özelliği";
            this.OdaOzelligi.Name = "OdaOzelligi";
            this.OdaOzelligi.Width = 120;
            // 
            // OdaTuru
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OdaTuru.DefaultCellStyle = dataGridViewCellStyle4;
            this.OdaTuru.HeaderText = "Oda Türü";
            this.OdaTuru.Name = "OdaTuru";
            // 
            // Ucret
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ucret.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ucret.HeaderText = "Ücret";
            this.Ucret.Name = "Ucret";
            // 
            // GirisTarih
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GirisTarih.DefaultCellStyle = dataGridViewCellStyle6;
            this.GirisTarih.HeaderText = "Giriş Tarihi";
            this.GirisTarih.Name = "GirisTarih";
            this.GirisTarih.Width = 120;
            // 
            // CikisTarihi
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CikisTarihi.DefaultCellStyle = dataGridViewCellStyle7;
            this.CikisTarihi.HeaderText = "Çıkış Tarihi";
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Width = 120;
            // 
            // YöneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_odaOzelligi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_besYildiz);
            this.Controls.Add(this.radioButton_dortYildiz);
            this.Controls.Add(this.radioButton_ucYildiz);
            this.Controls.Add(this.button_rezSorgu);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_odaTuru);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.comboBox_otelTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Cikis);
            this.Controls.Add(this.dateTimePicker_Giris);
            this.MaximizeBox = false;
            this.Name = "YöneticiForm";
            this.Text = "YöneticiForm";
            this.Load += new System.EventHandler(this.YöneticiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Giris;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_otelTuru;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.ComboBox comboBox_odaTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_rezSorgu;
        private System.Windows.Forms.RadioButton radioButton_ucYildiz;
        private System.Windows.Forms.RadioButton radioButton_dortYildiz;
        private System.Windows.Forms.RadioButton radioButton_besYildiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_odaOzelligi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtelTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaOzelligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarihi;
    }
}