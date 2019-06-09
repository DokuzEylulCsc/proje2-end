namespace OtelProgrami
{
    partial class uyeRezKayitlari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_RezGuncelle = new System.Windows.Forms.Button();
            this.button_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_RezGuncelle
            // 
            this.button_RezGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_RezGuncelle.Location = new System.Drawing.Point(49, 310);
            this.button_RezGuncelle.Name = "button_RezGuncelle";
            this.button_RezGuncelle.Size = new System.Drawing.Size(198, 70);
            this.button_RezGuncelle.TabIndex = 1;
            this.button_RezGuncelle.Text = "Rezervasyon Güncelle";
            this.button_RezGuncelle.UseVisualStyleBackColor = true;
            this.button_RezGuncelle.Click += new System.EventHandler(this.button_RezGuncelle_Click);
            // 
            // button_Cikis
            // 
            this.button_Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.Location = new System.Drawing.Point(516, 310);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(123, 70);
            this.button_Cikis.TabIndex = 2;
            this.button_Cikis.Text = "Çıkış";
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // uyeRezKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Cikis;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.button_RezGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "uyeRezKayitlari";
            this.Text = "Rezervasyon Kayıtlarınız";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_RezGuncelle;
        private System.Windows.Forms.Button button_Cikis;
    }
}