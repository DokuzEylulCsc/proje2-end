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
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaozellik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cıkıstarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sehir,
            this.otelisim,
            this.otelturu,
            this.odaturu,
            this.odaozellik,
            this.ucret,
            this.giristarih,
            this.cıkıstarih});
            this.dataGridView1.Location = new System.Drawing.Point(12, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Sil
            // 
            this.button_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sil.Location = new System.Drawing.Point(49, 310);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(198, 70);
            this.button_Sil.TabIndex = 1;
            this.button_Sil.Text = "Rezervasyon Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click_1);
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
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            // 
            // otelisim
            // 
            this.otelisim.HeaderText = "Otel İsim";
            this.otelisim.Name = "otelisim";
            this.otelisim.Width = 150;
            // 
            // otelturu
            // 
            this.otelturu.HeaderText = "Otel Türü";
            this.otelturu.Name = "otelturu";
            this.otelturu.Width = 150;
            // 
            // odaturu
            // 
            this.odaturu.HeaderText = "Oda Türü";
            this.odaturu.Name = "odaturu";
            this.odaturu.Width = 150;
            // 
            // odaozellik
            // 
            this.odaozellik.HeaderText = "Oda Özelliği";
            this.odaozellik.Name = "odaozellik";
            this.odaozellik.Width = 165;
            // 
            // ucret
            // 
            this.ucret.HeaderText = "Ücret";
            this.ucret.Name = "ucret";
            // 
            // giristarih
            // 
            this.giristarih.HeaderText = "Giriş Tarihi";
            this.giristarih.Name = "giristarih";
            this.giristarih.Width = 150;
            // 
            // cıkıstarih
            // 
            this.cıkıstarih.HeaderText = "Çıkış Tarihi";
            this.cıkıstarih.Name = "cıkıstarih";
            this.cıkıstarih.Width = 150;
            // 
            // uyeRezKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelProgrami.Properties.Resources._376352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Cikis;
            this.ClientSize = new System.Drawing.Size(1197, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "uyeRezKayitlari";
            this.Text = "Rezervasyon Kayıtlarınız";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Cikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaozellik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn cıkıstarih;
    }
}