using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace OtelProgrami
{
    public partial class UyeOl : Form
    {
<<<<<<< HEAD
        Log kayit = new Log();
=======
        //Uye uyeHataDurumunda = new Uye(); // Log eklemek icin uye nesnesi burada tutulabilir.
>>>>>>> 0e99e88693768377c7462bf6cdaa5848111b1cfe
        public UyeOl()
        {
            InitializeComponent();
        }
        internal Uye UyeHataDurumunda { get => UyeHataDurumunda; set => UyeHataDurumunda = value; }
        //kayit ol deyince yeni bir uye json bilgisi olustur
        private void button_Kayitol_Click(object sender, EventArgs e)
        {
            try
            {
                string ad =textBox_Ad.Text;
                string soyad = textBox_Soyad.Text;
                string telNo = textBox_Tel.Text;
                string tcNo = textBox_TcNo.Text;
                string sifre = textBox_Sifre.Text;
                //telefona veya tc nosuna string bir karakter girerse cath bloguna gitmesi saglandı
                int telNo_Kontrol = Convert.ToInt32(textBox_Tel.Text);
                int tcNo_Kontrol = Convert.ToInt32(textBox_TcNo.Text);
                //bilgileri boş bırakmasını istemiyoruz.
                if(textBox_Ad.Text==string.Empty || textBox_Sifre.Text==string.Empty || textBox_Tel.Text == string.Empty ||
                    textBox_TcNo.Text == string.Empty || textBox_Soyad.Text == string.Empty)
                {
                    onemli_ad.Visible = true;
                    onemli_sifre.Visible = true;
                    onemli_soyad.Visible = true;
                    onemli_tcNo.Visible = true;
                    onemli_tel.Visible = true;
                    MessageBox.Show("Lütfen Bilgileri Boş Bırakmayınız.");
                    //exception log kaydı gelecek.
                    kayit.logOlustur("Üye Olunurken Bilgiler Boş bırakıldı", DateTime.Now.ToString());
                    
                }
                //15 karakterden buyuk kullanıcı adı alamaz.
                else if (ad.Length>15)
                {
                    //hatayı nerede yaptıgı goruntulendi
                    onemli_ad.Visible = true;
                    MessageBox.Show("15 karakterden büyük yazdınız.");
                    kayit.logOlustur("Üye Olunurken Kullanıcı adı 15 karakterden fazla girildi",DateTime.Now.ToString());                 
                }
                else
                {
                    Uye yeniUye = new Uye(ad, soyad, telNo, tcNo, sifre);
                    yeniUye.KayitOl();
                    MessageBox.Show("Üye başarıyla kayıt oldu");
                }
               

            }
            catch (Exception exp)
            {
                //labelada nerede hata yaptıgını gösterdik.
                //ilk başta gozukmemesi için görünürlügünü kapattok ki hata yaptıgında gozuksun.
                onemli_tel.Visible = true;
                onemli_tcNo.Visible = true;
                //Log classi eklenecek uye kayit olamadi log'u olusturulacak
                kayit.logOlustur("Üye Olunurken Tel no veya Tc No girilirken harf kullanıldı", DateTime.Now.ToString());
                MessageBox.Show(exp.Message);
                string json = JsonConvert.SerializeObject(exp);
                MessageBox.Show(json);             
            }
            finally
            {

                textBox_Ad.Text = "";
                textBox_Soyad.Text = "";
                textBox_Tel.Text = "";
                textBox_TcNo.Text = "";
                textBox_Sifre.Text = "";
                //gorunurlügü geri kapattık ki bir daha hata yaparsa yeniden gözüksün.
                onemli_tel.Visible = false;
                onemli_tcNo.Visible = false;
                onemli_ad.Visible = false;
                onemli_sifre.Visible = false;
                onemli_soyad.Visible = false;
            }

        }

        private void sifreGizle_UyeOl_CheckedChanged(object sender, EventArgs e)
        {
            //şifre girerken sifrenin gözükmesi istenmediginden dolayı * koyarak gizledik.
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
