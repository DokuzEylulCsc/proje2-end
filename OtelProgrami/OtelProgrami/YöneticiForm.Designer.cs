namespace OtelProgrami
{
    partial class YöneticiForm
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
            this.comboBox_otelTuru.Location = new System.Drawing.Point(107, 43);
            this.comboBox_otelTuru.Name = "comboBox_otelTuru";
            this.comboBox_otelTuru.Size = new System.Drawing.Size(121, 24);
            this.comboBox_otelTuru.TabIndex = 4;
            // 
            // button_Ekle
            // 
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ekle.Location = new System.Drawing.Point(87, 362);
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
            this.comboBox_odaTuru.Location = new System.Drawing.Point(107, 95);
            this.comboBox_odaTuru.Name = "comboBox_odaTuru";
            this.comboBox_odaTuru.Size = new System.Drawing.Size(121, 24);
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
            this.button_Sil.Location = new System.Drawing.Point(326, 362);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(153, 54);
            this.button_Sil.TabIndex = 10;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            // 
            // button_rezSorgu
            // 
            this.button_rezSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_rezSorgu.Location = new System.Drawing.Point(557, 362);
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
            this.radioButton_ucYildiz.Location = new System.Drawing.Point(180, 147);
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
            this.radioButton_dortYildiz.Location = new System.Drawing.Point(315, 147);
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
            this.radioButton_besYildiz.Location = new System.Drawing.Point(456, 147);
            this.radioButton_besYildiz.Name = "radioButton_besYildiz";
            this.radioButton_besYildiz.Size = new System.Drawing.Size(78, 29);
            this.radioButton_besYildiz.TabIndex = 14;
            this.radioButton_besYildiz.TabStop = true;
            this.radioButton_besYildiz.Text = "*****";
            this.radioButton_besYildiz.UseVisualStyleBackColor = true;
            // 
            // YöneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
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
    }
}