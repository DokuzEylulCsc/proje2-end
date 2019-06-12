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
    public partial class uyeRezKayitlari : Form
    {
        
        public uyeRezKayitlari()
        {
            InitializeComponent();

        }


        private void button_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Sil_Click_1(object sender, EventArgs e)
        {

        }

        private void uyeRezKayitlari_Load(object sender, EventArgs e)
        {

            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Rezervasyonlar\";

            string[] fileEntries = Directory.GetFiles(filePath);

            foreach (var eleman in fileEntries)
            {
                // newton soft json okuma
                // read file into a string and deserialize JSON to a type
                Rezervasyon rez = JsonConvert.DeserializeObject<Rezervasyon>(File.ReadAllText(eleman));
                rezervasyonKayitlari.Rows.Add(rez.Sehir,rez.OtelIsmi,rez.OdaTuru,rez.OdaOzelligi,rez.OdaFiyati,rez.RezervasyonBaslangic,rez.RezervasyonBitis);
            }
        }
    }
}
