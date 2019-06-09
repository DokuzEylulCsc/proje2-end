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
            this.button_rezYap = new System.Windows.Forms.Button();
            this.comboBox_OtelTuru = new System.Windows.Forms.ComboBox();
            this.comboBox_OdaTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_rezKayitlari = new System.Windows.Forms.Button();
            this.uc_yildiz = new System.Windows.Forms.RadioButton();
            this.dort_yildiz = new System.Windows.Forms.RadioButton();
            this.bes_yildiz = new System.Windows.Forms.RadioButton();
            this.comboBox_odaOzellik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ucret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Sehir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker_Giris
            // 
            this.dateTimePicker_Giris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Location = new System.Drawing.Point(567, 43);
            this.dateTimePicker_Giris.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Giris.Name = "dateTimePicker_Giris";
            this.dateTimePicker_Giris.Size = new System.Drawing.Size(323, 24);
            this.dateTimePicker_Giris.TabIndex = 0;
            // 
            // dateTimePicker_Cikis
            // 
            this.dateTimePicker_Cikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Location = new System.Drawing.Point(567, 95);
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
            this.label1.Location = new System.Drawing.Point(466, 48);
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
            this.label2.Location = new System.Drawing.Point(464, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // button_rezYap
            // 
            this.button_rezYap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_rezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezYap.Location = new System.Drawing.Point(533, 282);
            this.button_rezYap.Margin = new System.Windows.Forms.Padding(5);
            this.button_rezYap.Name = "button_rezYap";
            this.button_rezYap.Size = new System.Drawing.Size(274, 74);
            this.button_rezYap.TabIndex = 4;
            this.button_rezYap.Text = "Rezervasyon Yap";
            this.button_rezYap.UseVisualStyleBackColor = false;
            this.button_rezYap.Click += new System.EventHandler(this.button_rezYap_Click);
            // 
            // comboBox_OtelTuru
            // 
            this.comboBox_OtelTuru.FormattingEnabled = true;
            this.comboBox_OtelTuru.Items.AddRange(new object[] {
            "Butik Otel",
            "Pansiyon",
            "Tatil Köyü"});
            this.comboBox_OtelTuru.Location = new System.Drawing.Point(165, 35);
            this.comboBox_OtelTuru.Name = "comboBox_OtelTuru";
            this.comboBox_OtelTuru.Size = new System.Drawing.Size(209, 33);
            this.comboBox_OtelTuru.TabIndex = 8;
            // 
            // comboBox_OdaTuru
            // 
            this.comboBox_OdaTuru.FormattingEnabled = true;
            this.comboBox_OdaTuru.Items.AddRange(new object[] {
            "Tek Kişilik",
            "İki Kişilik",
            "İkiz Yataklı Çift Kişilik",
            "Üç Kişilik "});
            this.comboBox_OdaTuru.Location = new System.Drawing.Point(165, 87);
            this.comboBox_OdaTuru.Name = "comboBox_OdaTuru";
            this.comboBox_OdaTuru.Size = new System.Drawing.Size(209, 33);
            this.comboBox_OdaTuru.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Otel Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oda Türü:";
            // 
            // button_rezKayitlari
            // 
            this.button_rezKayitlari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_rezKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezKayitlari.Location = new System.Drawing.Point(533, 404);
            this.button_rezKayitlari.Margin = new System.Windows.Forms.Padding(5);
            this.button_rezKayitlari.Name = "button_rezKayitlari";
            this.button_rezKayitlari.Size = new System.Drawing.Size(274, 74);
            this.button_rezKayitlari.TabIndex = 14;
            this.button_rezKayitlari.Text = "Rezervasyon Kayıtları";
            this.button_rezKayitlari.UseVisualStyleBackColor = false;
            this.button_rezKayitlari.Click += new System.EventHandler(this.button_rezKayitlari_Click);
            // 
            // uc_yildiz
            // 
            this.uc_yildiz.AutoSize = true;
            this.uc_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uc_yildiz.Location = new System.Drawing.Point(481, 221);
            this.uc_yildiz.Name = "uc_yildiz";
            this.uc_yildiz.Size = new System.Drawing.Size(60, 29);
            this.uc_yildiz.TabIndex = 15;
            this.uc_yildiz.TabStop = true;
            this.uc_yildiz.Text = "***";
            this.uc_yildiz.UseVisualStyleBackColor = false;
            // 
            // dort_yildiz
            // 
            this.dort_yildiz.AutoSize = true;
            this.dort_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dort_yildiz.Location = new System.Drawing.Point(640, 221);
            this.dort_yildiz.Name = "dort_yildiz";
            this.dort_yildiz.Size = new System.Drawing.Size(69, 29);
            this.dort_yildiz.TabIndex = 16;
            this.dort_yildiz.TabStop = true;
            this.dort_yildiz.Text = "****";
            this.dort_yildiz.UseVisualStyleBackColor = false;
            // 
            // bes_yildiz
            // 
            this.bes_yildiz.AutoSize = true;
            this.bes_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bes_yildiz.Location = new System.Drawing.Point(806, 221);
            this.bes_yildiz.Name = "bes_yildiz";
            this.bes_yildiz.Size = new System.Drawing.Size(78, 29);
            this.bes_yildiz.TabIndex = 17;
            this.bes_yildiz.TabStop = true;
            this.bes_yildiz.Text = "*****";
            this.bes_yildiz.UseVisualStyleBackColor = false;
            // 
            // comboBox_odaOzellik
            // 
            this.comboBox_odaOzellik.FormattingEnabled = true;
            this.comboBox_odaOzellik.Items.AddRange(new object[] {
            "Ekonomik",
            "Normal",
            "Dağ Manzarasi",
            "Deniz Manzarasi"});
            this.comboBox_odaOzellik.Location = new System.Drawing.Point(165, 137);
            this.comboBox_odaOzellik.Name = "comboBox_odaOzellik";
            this.comboBox_odaOzellik.Size = new System.Drawing.Size(209, 33);
            this.comboBox_odaOzellik.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Oda Özelliği:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ücret:";
            // 
            // textBox_ucret
            // 
            this.textBox_ucret.Location = new System.Drawing.Point(165, 239);
            this.textBox_ucret.Name = "textBox_ucret";
            this.textBox_ucret.Size = new System.Drawing.Size(209, 30);
            this.textBox_ucret.TabIndex = 21;
            this.textBox_ucret.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(22, 193);
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
            this.comboBox_Sehir.Location = new System.Drawing.Point(165, 185);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(209, 33);
            this.comboBox_Sehir.TabIndex = 23;
            // 
            // OtelRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 542);
            this.Controls.Add(this.comboBox_Sehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_ucret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_odaOzellik);
            this.Controls.Add(this.bes_yildiz);
            this.Controls.Add(this.dort_yildiz);
            this.Controls.Add(this.uc_yildiz);
            this.Controls.Add(this.button_rezKayitlari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_OdaTuru);
            this.Controls.Add(this.comboBox_OtelTuru);
            this.Controls.Add(this.button_rezYap);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Giris;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_rezYap;
        private System.Windows.Forms.ComboBox comboBox_OtelTuru;
        private System.Windows.Forms.ComboBox comboBox_OdaTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rezKayitlari;
        private System.Windows.Forms.RadioButton uc_yildiz;
        private System.Windows.Forms.RadioButton dort_yildiz;
        private System.Windows.Forms.RadioButton bes_yildiz;
        private System.Windows.Forms.ComboBox comboBox_odaOzellik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ucret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Sehir;
    }
}