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
    public partial class AnaGiris : Form
    {
        OtelRezervasyon rez = new OtelRezervasyon();
        YoneticiForm formYonetici = new YoneticiForm();

        Log kayit = new Log();
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            if (textBox_KullaniciTcNo.Text == string.Empty || textBox_Sifre.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adinizi veya Şifrenizi Yazmadınız.");
                kayit.logOlustur("Giriş yaparken Kullanici adini veya şifresini yazmadı", DateTime.Now.ToString());

            }
            else
            {
                string kullanici_TcNo = textBox_KullaniciTcNo.Text;
                string kullanici_Sifre = textBox_Sifre.Text;

                string filePath = System.IO.Directory.GetCurrentDirectory();
                filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Uyeler\";

                string[] fileEntries = Directory.GetFiles(filePath);

                bool kullaniciGirisiSaglandi = false;

                // kullanici girisi yapildi.
                foreach (var a in fileEntries)
                {
                    Uye uye = JsonConvert.DeserializeObject<Uye>(File.ReadAllText(a));
                    if (kullanici_TcNo == "admin" && kullanici_Sifre == "admin")
                    {
                        MessageBox.Show("Yonetici girişi yaptınız!");
                        formYonetici.Show();
                        kullaniciGirisiSaglandi = true;
                        break;
                    }
                    else if (uye.TcNo == kullanici_TcNo && uye.Sifre == kullanici_Sifre)
                    {
                        MessageBox.Show("Sayın " + uye.Ad + " " + uye.Soyad + " Hoşgeldiniz");
                        kullaniciGirisiSaglandi = true;
                        rez.Show();
                        break;
                    }
                }

                if (kullaniciGirisiSaglandi == false)
                {
                    
                    MessageBox.Show("Kullanıcı Bilgileriniz Yanlış Lütfen Tekrar Deneyiniz.");
                    kayit.logOlustur("Giriş yaparken Kullanici adini veya şifresini yanlış girdi", DateTime.Now.ToString());
                }
            }

        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.ShowDialog();

        }

        private void checkBox_sifregizle_CheckedChanged(object sender, EventArgs e)
        {
            //sifre gizlemek için yazıldı
            if (checkBox_sifregizle.Checked)
            {
                textBox_Sifre.PasswordChar = '\0';
            }
            else
            {
                textBox_Sifre.PasswordChar = '*';
            }
        }

        private void AnaGiris_Load(object sender, EventArgs e)
        {
            //OtelRezervasyon aa = new OtelRezervasyon();
           // aa.Show();
            //form load kısmına bu kodu yazdık cunku ilk girildiginde sifre göster butonuna basmadan gosteriyordu.
            textBox_Sifre.PasswordChar = '*';
        }
    }
}
