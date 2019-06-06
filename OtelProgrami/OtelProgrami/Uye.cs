using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OtelProgrami
{
    class Uye
    {
        string adSoyad;
        string tcNo;
        int yas;
        LinkedList<Rezervasyon> rezervasyonlarim = new LinkedList<Rezervasyon>();

        public Uye(string adsoyad, int yas, string tcno)
        {
            AdSoyad = adSoyad;
            TcNo = tcno;
            Yas = yas;
        }

        public Uye()
        {

        }

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public int Yas { get => yas; set => yas = value; }
        internal LinkedList<Rezervasyon> Rezervasyonlarim { get => rezervasyonlarim; set => rezervasyonlarim = value; }

        public void BilgileriniGuncelle(string yeniAdsoyad, string yeniTc, int yeniYas)
        {
            AdSoyad = yeniAdsoyad;
            TcNo = yeniTc;
            Yas = yeniYas;
        }

        public void RezervasyonIptalEt()
        {

        }

        // Sistem'e rezervasyon talebi gider, sistem uyenin talebine uygun sonuclari
        // uyeye bildirir.
        public void RezervasyonTalepEt()
        {

        }

        // Uye, sistemin sundugu uygun otel sonuclarindan birini secer,
        // ve rezervasyonu tamamlar.
        public void RezervasyonTamamla()
        {

        }
    }
}
