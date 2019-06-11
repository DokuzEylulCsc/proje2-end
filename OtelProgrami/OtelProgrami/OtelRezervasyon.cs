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

        public OtelRezervasyon()
        {
            InitializeComponent();
        }

        private void OtelRezervasyon_Load(object sender, EventArgs e)
        {
            //ucrete form üzerinden işlem yapılmasın sadece okunsun.
            textBox_ucret.ReadOnly = true;
            //ındexlendi ki exception hataları engellendi.
            comboBox_OtelIsim.SelectedIndex = 0;
            comboBox_OdaTuru.SelectedIndex = 0;
            //comboBox_OtelTuru.SelectedIndex = 0;
            comboBox_odaOzellik.SelectedIndex = 0;
            comboBox_Sehir.SelectedIndex = 0;
            uc_yildiz.Checked = true;
            uc_yildiz.Checked = true;
        }

        private void button_rezYap_Click(object sender, EventArgs e)
        {

            DateTime giris = dateTimePicker_Giris.Value.Date;
            DateTime cikis = dateTimePicker_Cikis.Value.Date;
            int yildiz;
            string otelIsmi = comboBox_OtelIsim.Text;
            string odaTuru = comboBox_OdaTuru.Text;
            string odaOzelligi = comboBox_odaOzellik.Text;
            if (uc_yildiz.Checked)
            {
                yildiz = 3;
            }
            else if (dort_yildiz.Checked)
            {
                yildiz = 4;
            }
            else
            {
                yildiz = 5;
            }
            MessageBox.Show(" , " + odaTuru + " ve " + yildiz + " yıldızlı otele " + giris.ToString("dd/MM/yyyy") + " - " + cikis.ToString("dd/MM/yyyy") + " tarihleri arasinda rezervasyon yaptınız.");
        }
        private void button_rezKayitlari_Click(object sender, EventArgs e)
        {
            //nesnemizi burada tanımlıyoruz ki form sayfası kapatıldıgında bır daha açılmak istendiginde hata vermesin.
            uyeRezKayitlari rez = new uyeRezKayitlari();
            rez.Show();
        }
    }
}
