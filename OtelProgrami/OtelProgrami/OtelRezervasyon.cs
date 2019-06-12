using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProgrami
{
    public partial class OtelRezervasyon : Form
    {
        Sistem sistem = new Sistem();
        Uye uye = new Uye();
       
        string sehir;
        string otelIsmi;
        string odaTuru;
        string odaFiyati;
        string odaOzelligi;
        string girisTarihi;
        string cikisTarihi;

        internal Sistem Sistem { get => sistem; set => sistem = value; }
        internal Uye Uye { get => uye; set => uye = value; }
       

        public OtelRezervasyon(Uye uye)
        {
            Uye = uye;
            InitializeComponent();
        }

        public OtelRezervasyon()
        {
            InitializeComponent();
        }

        private void OtelRezervasyon_Load(object sender, EventArgs e)
        {
            //ucrete form üzerinden işlem yapılmasın sadece okunsun.
            //indexlendi ki exception hatalari engellendi.
            comboBox_OdaTuru.SelectedIndex = 0;
            comboBox_odaOzellik.SelectedIndex = 0;
            comboBox_Sehir.SelectedIndex = 0;
            
        }

        private void rezervasyonSorgula_Click(object sender, EventArgs e)
        {
            string odaTuru = comboBox_OdaTuru.Text;
            string odaOzelligi = comboBox_odaOzellik.Text;
            string sehir = comboBox_Sehir.Text;

            DateTime giris = dateTimePicker_Giris.Value.Date;
            DateTime cikis = dateTimePicker_Cikis.Value.Date;

            // Rezervasyon Bul butonuna her basışta datagridview'i temizle
            uygunOdalar_dataGrid.Rows.Clear();

            // Sistem classi uygun odalari bulur
            Sistem.OdaAra(odaTuru, odaOzelligi, sehir, giris.ToString(), cikis.ToString());

            foreach (var oda in Sistem.UyeyeUygunOtelleriListele())
            {
                uygunOdalar_dataGrid.Rows.Add(oda.SehirBilgisi, oda.OtelIsmi, oda.OdaTuru, oda.OdaOzelligi, oda.Fiyat + " TL", giris.ToShortDateString(), cikis.ToShortDateString());
            }

            if (Sistem.BulunanOdalar.Count == 0)
                MessageBox.Show("Aradığınız kriterlere uygun oda ve otel bulunamadı.");
            else
                // Her sorgudan sonra listeyi sifirla
                Sistem.BulunanOdalar.Clear();

            // DataGridView'de otomatik ilk secimi kaldir.
            uygunOdalar_dataGrid.ClearSelection();
        }
        private void button_rezKayitlari_Click(object sender, EventArgs e)
        {
            //nesnemizi burada tanımlıyoruz ki form sayfası kapatıldıgında bır daha açılmak istendiginde hata vermesin.
            uyeRezKayitlari rez = new uyeRezKayitlari();
            rez.Show();

            // rezervasyon jsonlari arasinda tc bilgisine gore arama yapip rezervasyonlari gosterecek.
        }

        public void uygunOdalar_dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (uygunOdalar_dataGrid.SelectedCells.Count > 0)
            {
                sehir = uygunOdalar_dataGrid.CurrentRow.Cells[0].Value.ToString();
                otelIsmi = uygunOdalar_dataGrid.CurrentRow.Cells[1].Value.ToString();
                odaTuru = uygunOdalar_dataGrid.CurrentRow.Cells[2].Value.ToString();
                odaOzelligi = uygunOdalar_dataGrid.CurrentRow.Cells[3].Value.ToString();
                odaFiyati = uygunOdalar_dataGrid.CurrentRow.Cells[4].Value.ToString();
                girisTarihi = uygunOdalar_dataGrid.CurrentRow.Cells[5].Value.ToString();
                cikisTarihi = uygunOdalar_dataGrid.CurrentRow.Cells[6].Value.ToString();

            }
        }

        private void rezTamamla_Click(object sender, EventArgs e)
        {
            Rezervasyon rez = new Rezervasyon(uye.Ad, uye.Soyad, uye.TcNo, sehir, otelIsmi, odaFiyati, odaTuru, odaOzelligi, girisTarihi, cikisTarihi, uye);
            uye.RezervasyonTamamla(rez);
            MessageBox.Show(sehir + " sehrinde " + otelIsmi + " isimli " + odaFiyati + " TL " + odaTuru + " olan " + odaOzelligi + " olan " + girisTarihi + "-" + cikisTarihi + " arasında rezervasyon yaptınız.");
        }
    }
}
