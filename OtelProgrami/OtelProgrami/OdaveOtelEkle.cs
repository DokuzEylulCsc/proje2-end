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

    public partial class OdaveOtelEkle : Form
    {
        Yonetici yonetici= new Yonetici();

        public OdaveOtelEkle()
        {
            InitializeComponent();
        }

        internal Yonetici Yonetici { get => yonetici; set => yonetici = value; }

        private void odaEkle_Click(object sender, EventArgs e)
        {
            
            int odaFiyati = Int32.Parse(odaFiyat.Text);
            string odaTuru = comboBox_OdaTuru.Text;
            string otelIsmi = comboBox_OtelIsmi.Text;
            string odaOzelligi = comboBox_odaOzelligi.Text;
            string sehir = odaSehir.Text;


            if (odaTuru == "Tek Kişilik")
            {
                TekKisilikOda oda = new TekKisilikOda(odaFiyati, odaOzelligi);
                oda.OdaBilgiGir(otelIsmi, sehir, odaOzelligi);
                Yonetici.OdaEkle(oda);
                MessageBox.Show("Odayı Basarı İle Eklediniz.");
            }
            else if (odaTuru == "Çift Kişilik")
            {
                CiftKisilikOda oda = new CiftKisilikOda(odaFiyati, odaOzelligi);
                oda.OdaBilgiGir(otelIsmi, sehir, odaOzelligi);
                Yonetici.OdaEkle(oda);
                MessageBox.Show("Odayı Basarı İle Eklediniz.");
            }
            else if (odaTuru == "İkiz Yataklı Çift Kişilik")
            {
                IkizYatakliOda oda = new IkizYatakliOda(odaFiyati, odaOzelligi);
                oda.OdaBilgiGir(otelIsmi, sehir, odaOzelligi);
                Yonetici.OdaEkle(oda);
                MessageBox.Show("Odayı Basarı İle Eklediniz.");
            }
            else if (odaTuru == "Üç Kişilik")
            {
                UcKisilikOda oda = new UcKisilikOda(odaFiyati, odaOzelligi);
                oda.OdaBilgiGir(otelIsmi, sehir, odaOzelligi);
                Yonetici.OdaEkle(oda);
                MessageBox.Show("Odayı Basarı İle Eklediniz.");
            }
         
        }

        private void otelEkle_Click(object sender, EventArgs e)
        {
            string otelIsmi = otelIsim.Text;
            string sehir = otelSehir.Text;
            string otelTur = comboBox_otelTuru_otel.Text;
            int yildizSy;

            if (radioButton_ucYildiz.Checked)
                yildizSy = 3;
            else if (radioButton_dortYildiz.Checked)
                yildizSy = 4;
            else
                yildizSy = 5;

            Otel otel = new Otel(otelIsmi, sehir, yildizSy, otelTur);
            Yonetici.OtelEkle(otel);
            MessageBox.Show("Oteli Basarı İle Eklediniz.");

           
        }
    }
}
