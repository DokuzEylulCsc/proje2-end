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
        public OdaveOtelEkle()
        {
            InitializeComponent();
        }

        private void odaEkle_Click(object sender, EventArgs e)
        {
            string odaFiyati = odaFiyat.Text;
            string kisiKap = odaKisiKapasitesi.Text;
            string otelAd = odaOtelIsim.Text;
            bool klimaBilgisi = odaKlimaChck.Checked;
            bool minibarBilgisi = odaMinibarChck.Checked;
            bool denizBilgisi = odaDenizChck.Checked;
            bool dagBilgisi = odaDagChck.Checked;
            bool ekoBilgisi = odaEkoChck.Checked;
        }

        private void otelEkle_Click(object sender, EventArgs e)
        {
            string otelIsmi = otelIsim.Text;
            string sehir = otelSehir.Text;
            int yildizSy = Int32.Parse(otelYildiz.Text);
            //string 
        }

        //internal string Serialize(Object o)
        //{
        //    //Serilestirip, Json'u guzel bicimde yazdiriyor.
        //    return JToken.Parse(JsonConvert.SerializeObject(o)).ToString(Formatting.Indented);
        //}

        //internal Uye Deserialize(string serialized)
        //{
        //    return JsonConvert.DeserializeObject<Uye>(serialized);
        //}

        //// JSONVeri/Uyeler klasörune yeni uye'nin json olarak bilgilerini yazdir
        //internal void KayitOl()
        //{
        //    string filePath = System.IO.Directory.GetCurrentDirectory();
        //    filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Uyeler\";

        //    // ...\JSONVeri\Uyeler\Ahmet Mehmet 4534323122.json
        //    File.WriteAllText(filePath + this.Ad + " " + this.Soyad + " " + this.TcNo + ".json", this.Serialize(this));
        //}
    }
}
