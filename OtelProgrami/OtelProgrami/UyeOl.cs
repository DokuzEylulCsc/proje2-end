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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        //kayit ol deyince yeni bir uye json bilgisi olustur
        private void button_Kayitol_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox_Ad.Text;
                string soyad = textBox_Soyad.Text;
                string telNo = textBox_Tel.Text;
                string tcNo = textBox_TcNo.Text;
                string sifre = textBox_Sifre.Text;
                Uye yeniUye = new Uye(ad, soyad, telNo, tcNo, sifre);
                yeniUye.KayitOl();

                MessageBox.Show("Üye başarıyla kayıt oldu");

                textBox_Ad.Text = "";
                textBox_Soyad.Text = "";
                textBox_Tel.Text = "";
                textBox_TcNo.Text = "";
                textBox_Sifre.Text = "";
            }
            catch (Exception hata)
            {
                //Log classi eklenecek uye kayit olamadi log'u olusturulacak
                MessageBox.Show(hata.Message);
            }

        }

        private void sifreGizle_UyeOl_CheckedChanged(object sender, EventArgs e)
        {

            if (sifreGizle_UyeOl.Checked)
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
