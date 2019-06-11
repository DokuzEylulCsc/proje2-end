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

        internal Sistem Sistem { get => sistem; set => sistem = value; }

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

        private void button_rezYap_Click(object sender, EventArgs e)
        {
            string odaTuru = comboBox_OdaTuru.Text;
            string odaOzelligi = comboBox_odaOzellik.Text;
            //string otelIsmi = comboBox_OtelIsim.Text;
            string sehir = comboBox_Sehir.Text;

            DateTime giris = dateTimePicker_Giris.Value.Date;
            DateTime cikis = dateTimePicker_Cikis.Value.Date;

            // Rezervasyon Bul butonuna her basışta datagridview'i temizle
            uygunOdalar_dataGrid.Rows.Clear();

            Sistem.OdaAra(odaTuru, odaOzelligi, sehir);

            foreach (var oda in Sistem.BulunanOdalar)
            {
                uygunOdalar_dataGrid.Rows.Add(oda.SehirBilgisi, oda.OtelIsmi, oda.OdaTuru, oda.OdaOzelligi, oda.Fiyat, giris.ToShortDateString(), cikis.ToShortDateString());
            }

            if (Sistem.BulunanOdalar.Count == 0)
                MessageBox.Show("Aradığınız kriterlere uygun oda bulunamadı");
            else
                // Her sorgudan sonra listeyi sifirla
                Sistem.BulunanOdalar.Clear();
        }
        private void button_rezKayitlari_Click(object sender, EventArgs e)
        {
            //nesnemizi burada tanımlıyoruz ki form sayfası kapatıldıgında bır daha açılmak istendiginde hata vermesin.
            uyeRezKayitlari rez = new uyeRezKayitlari();
            rez.Show();
        }
    }
}
