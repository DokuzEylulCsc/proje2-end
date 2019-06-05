using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OtelProgrami
{
    class uyeİslem
    {
        Database db = new Database();
        OtelRezervasyon rez = new OtelRezervasyon();
        YoneticiForm frm = new YoneticiForm();
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut { get; set; }
        public string girisDurumu { get; set; }
        public void giris(string kullaniciAdi, string kullaniciSifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            //girişteki kullanici veya sifre girme hatası log kaydı için
            try
            {
                db.baglanti.Open();
                SqlCommand loginName = new SqlCommand("select kullaniciAdi from kullaniciBilgileri where kullaniciAdi=@kulAdi", db.baglanti);
                loginName.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                SqlDataReader kulAdi_oku = loginName.ExecuteReader();            
                if (kulAdi_oku.Read())
                {
                    kullaniciAdi_tut = kulAdi_oku["kullaniciAdi"].ToString();
                    SqlCommand loginpasword = new SqlCommand("select kullaniciSifre from kullaniciBilgileri where kullaniciSifre = @kulSifre", db.baglanti);
                    loginName.Parameters.AddWithValue("kulSifre", kullaniciSifre);
                    SqlDataReader kulSifre_oku = loginpasword.ExecuteReader();
                    if(kulSifre_oku.Read())
                    {
                        kullaniciSifre_tut = kulSifre_oku["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
                        if(kullaniciAdi_tut=="Admin" && kullaniciSifre_tut=="Admin")
                        {
                            frm.ShowDialog();
                        }
                        rez.ShowDialog();
                       // dateUpdate.Parameters
                    }
                    else
                    {
                        MessageBox.Show("Kullanici Şifresini Yanlış Girdiniz.","Hata|AnaGiris", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    loginpasword.Dispose();
                    kulSifre_oku.Close();   
                }
                else
                {
                    MessageBox.Show("Kullanici Adini Yanlış Girdiniz.","Hata|AnaGiris",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_oku.Close();              
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kayit(string ad, string soyad, string e_mail, string kullanici_Adi, string tel, string sifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kayit_al = new SqlCommand("insert into Musteriler values(@ad,@soyad,@tel,@eMail,@kullaniciAdi,@kullaniciSifre)", db.baglanti);
                kayit_al.Parameters.AddWithValue("ad",ad);
                kayit_al.Parameters.AddWithValue("soyad",soyad);
                kayit_al.Parameters.AddWithValue("tel",tel);
                kayit_al.Parameters.AddWithValue("eMail",e_mail);
                kayit_al.Parameters.AddWithValue("kullaniciAdi",kullanici_Adi);
                kayit_al.Parameters.AddWithValue("kullaniciSifre",sifre);
                kayit_al.ExecuteNonQuery();
                MessageBox.Show("Merhaba " + ad + " kaydınız başarı ile oluşturulmuştur.");
                kayit_al.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
