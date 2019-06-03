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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string kullanici_Adi = textBox_KullaniciAdi.Text;
            int kullanici_Sifre = Int32.Parse(textBox_Sifre.Text);//ınt mi string mi?
            //Kullanıcı kontrole veriler gönderilip kontrol edilecek
            //bunlar o klasa aktarılacak.
            //OtelRezervasyon rez = new OtelRezervasyon();
            //rez.ShowDialog();

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
    }
}
