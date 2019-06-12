using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProgrami
{
    public partial class YoneticiForm : Form
    {
        OdaveOtelEkle ekle = new OdaveOtelEkle();
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void YöneticiForm_Load(object sender, EventArgs e)
        {
            comboBox_odaOzelligi.SelectedIndex = 0;
            comboBox_odaTuru.SelectedIndex = 0;
            comboBox_otelTuru.SelectedIndex = 0;
        }

        private void button_rezSorgu_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Rezervasyonlar\";

            string[] fileEntries = Directory.GetFiles(filePath);

            foreach (var eleman in fileEntries)
            {
                // newton soft json okuma
                // read file into a string and deserialize JSON to a type
                Rezervasyon rez = JsonConvert.DeserializeObject<Rezervasyon>(File.ReadAllText(eleman));
                RezervasyonListesi.Rows.Add(rez.Ad,rez.Soyad,rez.TcNo,rez.Sehir, rez.OtelIsmi, rez.OdaTuru, rez.OdaOzelligi, rez.OdaFiyati, rez.RezervasyonBaslangic, rez.RezervasyonBitis);
            }
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            ekle.Show();
        }
    }
}
