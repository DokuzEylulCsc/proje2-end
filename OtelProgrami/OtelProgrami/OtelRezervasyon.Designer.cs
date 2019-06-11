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
            this.button_Bul = new System.Windows.Forms.Button();
            this.comboBox_OdaTuru = new System.Windows.Forms.ComboBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_OtelIsim = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelIsım = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtelTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaOzelligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giristarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cikistarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Giris
            // 
            this.dateTimePicker_Giris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Giris.Location = new System.Drawing.Point(749, 25);
            this.dateTimePicker_Giris.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Giris.Name = "dateTimePicker_Giris";
            this.dateTimePicker_Giris.Size = new System.Drawing.Size(323, 21);
            this.dateTimePicker_Giris.TabIndex = 0;
            // 
            // dateTimePicker_Cikis
            // 
            this.dateTimePicker_Cikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_Cikis.Location = new System.Drawing.Point(749, 77);
            this.dateTimePicker_Cikis.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Cikis.Name = "dateTimePicker_Cikis";
            this.dateTimePicker_Cikis.Size = new System.Drawing.Size(323, 21);
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
            this.label1.Size = new System.Drawing.Size(78, 15);
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
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // button_Bul
            // 
            this.button_Bul.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Bul.Location = new System.Drawing.Point(620, 183);
            this.button_Bul.Margin = new System.Windows.Forms.Padding(5);
            this.button_Bul.Name = "button_Bul";
            this.button_Bul.Size = new System.Drawing.Size(221, 74);
            this.button_Bul.TabIndex = 4;
            this.button_Bul.Text = "Rezervasyon Bul";
            this.button_Bul.UseVisualStyleBackColor = false;
            this.button_Bul.Click += new System.EventHandler(this.button_rezYap_Click);
            // 
            // comboBox_OdaTuru
            // 
            this.comboBox_OdaTuru.FormattingEnabled = true;
            this.comboBox_OdaTuru.Items.AddRange(new object[] {
            "Tek Kişilik",
            "İki Kişilik",
            "İkiz Yataklı Çift Kişilik",
            "Üç Kişilik "});
            this.comboBox_OdaTuru.Location = new System.Drawing.Point(166, 64);
            this.comboBox_OdaTuru.Name = "comboBox_OdaTuru";
            this.comboBox_OdaTuru.Size = new System.Drawing.Size(209, 28);
            this.comboBox_OdaTuru.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oda Türü:";
            // 
            // button_rezKayitlari
            // 
            this.button_rezKayitlari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_rezKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezKayitlari.Location = new System.Drawing.Point(900, 183);
            this.button_rezKayitlari.Margin = new System.Windows.Forms.Padding(5);
            this.button_rezKayitlari.Name = "button_rezKayitlari";
            this.button_rezKayitlari.Size = new System.Drawing.Size(214, 74);
            this.button_rezKayitlari.TabIndex = 14;
            this.button_rezKayitlari.Text = "Rezervasyon Kayıtları";
            this.button_rezKayitlari.UseVisualStyleBackColor = false;
            this.button_rezKayitlari.Click += new System.EventHandler(this.button_rezKayitlari_Click);
            // 
            // uc_yildiz
            // 
            this.uc_yildiz.AutoSize = true;
            this.uc_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uc_yildiz.Location = new System.Drawing.Point(669, 127);
            this.uc_yildiz.Name = "uc_yildiz";
            this.uc_yildiz.Size = new System.Drawing.Size(48, 24);
            this.uc_yildiz.TabIndex = 15;
            this.uc_yildiz.TabStop = true;
            this.uc_yildiz.Text = "***";
            this.uc_yildiz.UseVisualStyleBackColor = false;
            // 
            // dort_yildiz
            // 
            this.dort_yildiz.AutoSize = true;
            this.dort_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dort_yildiz.Location = new System.Drawing.Point(833, 127);
            this.dort_yildiz.Name = "dort_yildiz";
            this.dort_yildiz.Size = new System.Drawing.Size(55, 24);
            this.dort_yildiz.TabIndex = 16;
            this.dort_yildiz.TabStop = true;
            this.dort_yildiz.Text = "****";
            this.dort_yildiz.UseVisualStyleBackColor = false;
            // 
            // bes_yildiz
            // 
            this.bes_yildiz.AutoSize = true;
            this.bes_yildiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bes_yildiz.Location = new System.Drawing.Point(994, 127);
            this.bes_yildiz.Name = "bes_yildiz";
            this.bes_yildiz.Size = new System.Drawing.Size(62, 24);
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
            "Dağ Manzarası",
            "Deniz Manzarası"});
            this.comboBox_odaOzellik.Location = new System.Drawing.Point(166, 114);
            this.comboBox_odaOzellik.Name = "comboBox_odaOzellik";
            this.comboBox_odaOzellik.Size = new System.Drawing.Size(209, 28);
            this.comboBox_odaOzellik.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Oda Özelliği:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(22, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ücret:";
            // 
            // textBox_ucret
            // 
            this.textBox_ucret.Location = new System.Drawing.Point(166, 270);
            this.textBox_ucret.Name = "textBox_ucret";
            this.textBox_ucret.Size = new System.Drawing.Size(209, 26);
            this.textBox_ucret.TabIndex = 21;
            this.textBox_ucret.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(23, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
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
            this.comboBox_Sehir.Location = new System.Drawing.Point(166, 224);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(209, 28);
            this.comboBox_Sehir.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(22, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Otel İsmi:";
            // 
            // comboBox_OtelIsim
            // 
            this.comboBox_OtelIsim.FormattingEnabled = true;
            this.comboBox_OtelIsim.Items.AddRange(new object[] {
            "Şahmeran",
            "Yıldız Otel",
            "Huzur Oteli",
            "Asos Oteli",
            "Rest Otel",
            "Otel Beşiktaş"});
            this.comboBox_OtelIsim.Location = new System.Drawing.Point(166, 167);
            this.comboBox_OtelIsim.Name = "comboBox_OtelIsim";
            this.comboBox_OtelIsim.Size = new System.Drawing.Size(209, 28);
            this.comboBox_OtelIsim.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sehir,
            this.otelIsım,
            this.OtelTuru,
            this.OdaTuru,
            this.OdaOzelligi,
            this.Ucret,
            this.Giristarih,
            this.Cikistarih});
            this.dataGridView1.Location = new System.Drawing.Point(2, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 216);
            this.dataGridView1.TabIndex = 26;
            // 
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            // 
            // otelIsım
            // 
            this.otelIsım.HeaderText = "Otel İsim";
            this.otelIsım.Name = "otelIsım";
            this.otelIsım.Width = 150;
            // 
            // OtelTuru
            // 
            this.OtelTuru.HeaderText = "Otel Türü";
            this.OtelTuru.Name = "OtelTuru";
            this.OtelTuru.Width = 150;
            // 
            // OdaTuru
            // 
            this.OdaTuru.HeaderText = "Oda Türü";
            this.OdaTuru.Name = "OdaTuru";
            this.OdaTuru.Width = 150;
            // 
            // OdaOzelligi
            // 
            this.OdaOzelligi.HeaderText = "Oda Özelliği";
            this.OdaOzelligi.Name = "OdaOzelligi";
            this.OdaOzelligi.Width = 160;
            // 
            // Ucret
            // 
            this.Ucret.HeaderText = "Ücret";
            this.Ucret.Name = "Ucret";
            // 
            // Giristarih
            // 
            this.Giristarih.HeaderText = "Giriş Tarihi";
            this.Giristarih.Name = "Giristarih";
            this.Giristarih.Width = 150;
            // 
            // Cikistarih
            // 
            this.Cikistarih.HeaderText = "Çıkış Tarihi";
            this.Cikistarih.Name = "Cikistarih";
            this.Cikistarih.Width = 150;
            // 
            // OtelRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_OtelIsim);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.comboBox_OdaTuru);
            this.Controls.Add(this.button_Bul);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Giris;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Bul;
        private System.Windows.Forms.ComboBox comboBox_OdaTuru;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_OtelIsim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelIsım;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtelTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaOzelligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giristarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cikistarih;
    }
}