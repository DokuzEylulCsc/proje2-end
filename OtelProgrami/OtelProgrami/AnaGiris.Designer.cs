namespace OtelProgrami
{
    partial class AnaGiris
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
            this.button_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Kayit = new System.Windows.Forms.Button();
            this.textBox_KullaniciTcNo = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_sifregizle = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_giris.Location = new System.Drawing.Point(353, 249);
            this.button_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(179, 34);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc No:";
            // 
            // Kayit
            // 
            this.Kayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kayit.Location = new System.Drawing.Point(353, 316);
            this.Kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(179, 34);
            this.Kayit.TabIndex = 2;
            this.Kayit.Text = "Kayıt Ol";
            this.Kayit.UseVisualStyleBackColor = false;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // textBox_KullaniciTcNo
            // 
            this.textBox_KullaniciTcNo.Location = new System.Drawing.Point(353, 114);
            this.textBox_KullaniciTcNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_KullaniciTcNo.Multiline = true;
            this.textBox_KullaniciTcNo.Name = "textBox_KullaniciTcNo";
            this.textBox_KullaniciTcNo.Size = new System.Drawing.Size(179, 24);
            this.textBox_KullaniciTcNo.TabIndex = 3;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(353, 176);
            this.textBox_Sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Sifre.Multiline = true;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(179, 24);
            this.textBox_Sifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(295, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // checkBox_sifregizle
            // 
            this.checkBox_sifregizle.AutoSize = true;
            this.checkBox_sifregizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_sifregizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_sifregizle.Location = new System.Drawing.Point(552, 176);
            this.checkBox_sifregizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_sifregizle.Name = "checkBox_sifregizle";
            this.checkBox_sifregizle.Size = new System.Drawing.Size(129, 22);
            this.checkBox_sifregizle.TabIndex = 6;
            this.checkBox_sifregizle.Text = "Şireyi Göster";
            this.checkBox_sifregizle.UseVisualStyleBackColor = false;
            this.checkBox_sifregizle.CheckedChanged += new System.EventHandler(this.checkBox_sifregizle_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtelProgrami.Properties.Resources.Deniz_Manzarasi_a5ac1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_sifregizle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciTcNo);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AnaGiris";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.AnaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.TextBox textBox_KullaniciTcNo;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_sifregizle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

