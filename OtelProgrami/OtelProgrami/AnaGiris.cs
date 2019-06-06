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
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            //Uye giris = new Uye();
           
            if (textBox_KullaniciAdi.Text==string.Empty || textBox_Sifre.Text==string.Empty)
            {
                MessageBox.Show("Kullanıcı Adinizi veya Şifrenizi Yazmadınız.");
            }
            else
            {
                string kullanici_Adi = textBox_KullaniciAdi.Text;
                string kullanici_Sifre = textBox_Sifre.Text;
                //giris.giris(kullanici_Adi, kullanici_Sifre);
            }
        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.ShowDialog();
            
        }

        private void checkBox_sifregizle_CheckedChanged(object sender, EventArgs e)
        {
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
            textBox_Sifre.PasswordChar = '*';
        }
    }
}
