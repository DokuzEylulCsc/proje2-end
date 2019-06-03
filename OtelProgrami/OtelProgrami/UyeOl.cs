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

        private void button_Kayitol_Click(object sender, EventArgs e)
        {
            string ad = textBox_Ad.Text;
            string soyad = textBox_Soyad.Text;
            string e_mail = textBox_Email.Text;
            string kullanici_Adi = textBox_KullaniciAdi.Text;
            string tel = textBox_Tel.Text;
            int sifre = Int32.Parse(textBox_Sifre.Text);


        }
    }
}
