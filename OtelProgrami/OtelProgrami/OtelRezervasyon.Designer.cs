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
            this.button2 = new System.Windows.Forms.Button();
            this.uc_yildiz = new System.Windows.Forms.RadioButton();
            this.dort_yildiz = new System.Windows.Forms.RadioButton();
            this.bes_yildiz = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.button_rezYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_rezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezYap.Location = new System.Drawing.Point(307, 245);
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
            this.comboBox_OtelTuru.Location = new System.Drawing.Point(138, 34);
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
            this.comboBox_OdaTuru.Location = new System.Drawing.Point(138, 87);
            this.comboBox_OdaTuru.Name = "comboBox_OdaTuru";
            this.comboBox_OdaTuru.Size = new System.Drawing.Size(209, 33);
            this.comboBox_OdaTuru.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Otel Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oda Türü:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(307, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 74);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rezervasyon Kayıtları";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // uc_yildiz
            // 
            this.uc_yildiz.AutoSize = true;
            this.uc_yildiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_yildiz.Location = new System.Drawing.Point(199, 176);
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
            this.dort_yildiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dort_yildiz.Location = new System.Drawing.Point(367, 176);
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
            this.bes_yildiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bes_yildiz.Location = new System.Drawing.Point(533, 176);
            this.bes_yildiz.Name = "bes_yildiz";
            this.bes_yildiz.Size = new System.Drawing.Size(78, 29);
            this.bes_yildiz.TabIndex = 17;
            this.bes_yildiz.TabStop = true;
            this.bes_yildiz.Text = "*****";
            this.bes_yildiz.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtelProgrami.Properties.Resources.Deniz_Manzarasi_a5ac1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // OtelRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 542);
            this.Controls.Add(this.bes_yildiz);
            this.Controls.Add(this.dort_yildiz);
            this.Controls.Add(this.uc_yildiz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_OdaTuru);
            this.Controls.Add(this.comboBox_OtelTuru);
            this.Controls.Add(this.button_rezYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Cikis);
            this.Controls.Add(this.dateTimePicker_Giris);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "OtelRezervasyon";
            this.Text = "OtelRezervasyon";
            this.Load += new System.EventHandler(this.OtelRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton uc_yildiz;
        private System.Windows.Forms.RadioButton dort_yildiz;
        private System.Windows.Forms.RadioButton bes_yildiz;
    }
}